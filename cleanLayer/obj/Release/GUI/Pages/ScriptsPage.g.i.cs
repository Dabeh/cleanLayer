﻿#pragma checksum "..\..\..\..\GUI\Pages\ScriptsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6BCBD5CAE0AC8E9B10A3E77B0166AC69"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using cleanLayer.GUI;


namespace cleanLayer.GUI.Pages {
    
    
    /// <summary>
    /// ScriptsPage
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class ScriptsPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\GUI\Pages\ScriptsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonStart;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\GUI\Pages\ScriptsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonStop;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\GUI\Pages\ScriptsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxScripts;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\GUI\Pages\ScriptsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridSplitter splitter;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/cleanLayer;component/gui/pages/scriptspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\GUI\Pages\ScriptsPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.buttonStart = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\GUI\Pages\ScriptsPage.xaml"
            this.buttonStart.Click += new System.Windows.RoutedEventHandler(this.buttonStart_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonStop = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\GUI\Pages\ScriptsPage.xaml"
            this.buttonStop.Click += new System.Windows.RoutedEventHandler(this.buttonStop_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listBoxScripts = ((System.Windows.Controls.ListBox)(target));
            
            #line 32 "..\..\..\..\GUI\Pages\ScriptsPage.xaml"
            this.listBoxScripts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBoxScripts_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.splitter = ((System.Windows.Controls.GridSplitter)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
