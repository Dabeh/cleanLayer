﻿using System;
using System.Collections.Generic;

namespace cleanCore
{

    public static class WoWParty
    {

        public static int NumPartyMembers
        {
            get
            {
                int ret = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (GetPartyMemberGuid(i) != 0)
                        ret++;
                }
                return ret;
            }
        }

        public static WoWObject GetPartyMember(int index)
        {
            return Manager.GetObjectByGuid(GetPartyMemberGuid(index));
        }

        public static ulong GetPartyMemberGuid(int index)
        {
            return Helper.Magic.Read<ulong>(new IntPtr(Offsets.PartyArray + (index * 8)));
        }

        public static List<WoWPlayer> Members
        {
            get
            {
                var ret = new List<WoWPlayer>();
                for (int i = 0; i < 4; i++)
                {
                    var unit = GetPartyMember(i) as WoWPlayer;
                    if (unit != null && unit.IsValid)
                        ret.Add(unit);
                }
                ret.Add(Manager.LocalPlayer);
                return ret;
            }
        }
    }
}