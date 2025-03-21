﻿/*
Win3mu - Windows 3 Emulator
Copyright (C) 2017 Topten Software.

Win3mu is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Win3mu is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Win3mu.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win3muCore
{
    [MappedType]
    public struct HMMIO
    {
        public IntPtr value;

        public static HMMIO Null = new HMMIO() { value = IntPtr.Zero };
        public static HandleMap Map = new HandleMap();
        public static HMMIO To32(ushort h) { return new HMMIO() { value = Map.To32(h) }; }
        public static ushort To16(HMMIO h) { return Map.To16(h.value); }
        public static void Destroy(ushort h) { Map.Destroy16(h); }
    }
}
