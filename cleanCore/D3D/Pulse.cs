﻿using System;
using System.Windows.Forms;
using WhiteMagic.Internals;


namespace cleanCore.D3D
{
    public static class Pulse
    {
        private static Direct3DAPI.Direct3D9EndScene _endSceneDelegate;
        private static Direct3DAPI.Direct3D9Reset _resetDelegate;
        private static Direct3DAPI.Direct3D9ResetEx _resetExDelegate;
        private static Detour _endSceneHook;
        private static Detour _resetHook;
        private static Detour _resetExHook;

        private static readonly object _frameLock = new object();
        public static IntPtr EndScenePointer = IntPtr.Zero;
        public static IntPtr ResetPointer = IntPtr.Zero;
        public static IntPtr ResetExPointer = IntPtr.Zero;

        public static event EventHandler OnFrame;

        private static int EndSceneHook(IntPtr device)
        {
            lock (_frameLock)
            {
                if (!Rendering.IsInitialized)
                {
                    Rendering.Initialize(device);
                    //Camera.ScreenHeight = WoWScript.Execute<int>("GetScreenHeight()", 0);
                    //Camera.ScreenWidth = WoWScript.Execute<int>("GetScreenWidth()", 0);
                }

                Manager.Pulse();
                Events.Pulse();
                Rendering.Pulse();

                if (OnFrame != null)
                    OnFrame(null, new EventArgs());
            }

            return (int)_endSceneHook.CallOriginal(device);
        }

        private static int ResetHook(IntPtr device, Direct3DAPI.PresentParameters pp)
        {
            return (int)_resetHook.CallOriginal(device, pp);
        }

        public static void Initialize()
        {
            var window = new Form();
            IntPtr direct3D = Direct3DAPI.Direct3DCreate9(Direct3DAPI.SDKVersion);
            if (direct3D == IntPtr.Zero)
                throw new Exception("Direct3DCreate9 failed (SDK Version: " + Direct3DAPI.SDKVersion + ")");
            var pp = new Direct3DAPI.PresentParameters { Windowed = true, SwapEffect = 1, BackBufferFormat = 0 };
            var createDevice = Helper.Magic.RegisterDelegate<Direct3DAPI.Direct3D9CreateDevice>(Helper.Magic.GetObjectVtableFunction(direct3D, 16));
            IntPtr device;
            if (createDevice(direct3D, 0, 1, window.Handle, 0x20, ref pp, out device) < 0)
                throw new Exception("Failed to create device");

            EndScenePointer = Helper.Magic.GetObjectVtableFunction(device, Direct3DAPI.EndSceneOffset);
            ResetPointer = Helper.Magic.GetObjectVtableFunction(device, Direct3DAPI.ResetOffset);
            ResetExPointer = Helper.Magic.GetObjectVtableFunction(device, Direct3DAPI.ResetExOffset);

            var deviceRelease = Helper.Magic.RegisterDelegate<Direct3DAPI.D3DRelease>(Helper.Magic.GetObjectVtableFunction(device, 2));
            var release = Helper.Magic.RegisterDelegate<Direct3DAPI.D3DRelease>(Helper.Magic.GetObjectVtableFunction(direct3D, 2));

            deviceRelease(device);
            release(direct3D);
            window.Dispose();

            _endSceneDelegate = Helper.Magic.RegisterDelegate<Direct3DAPI.Direct3D9EndScene>(EndScenePointer);
            _endSceneHook = Helper.Magic.Detours.CreateAndApply(_endSceneDelegate,
                                                                new Direct3DAPI.Direct3D9EndScene(EndSceneHook),
                                                                "EndScene");
            _resetDelegate = Helper.Magic.RegisterDelegate<Direct3DAPI.Direct3D9Reset>(ResetPointer);
            _resetHook = Helper.Magic.Detours.CreateAndApply(_resetDelegate,
                                                                new Direct3DAPI.Direct3D9Reset(ResetHook),
                                                                "Reset");

        }
    }
}