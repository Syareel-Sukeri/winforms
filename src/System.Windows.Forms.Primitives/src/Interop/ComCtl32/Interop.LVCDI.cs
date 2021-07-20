﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

internal static partial class Interop
{
    internal static partial class ComCtl32
    {
        [Flags]
        public enum LVCDI : uint
        {
            ITEM = 0x00000000,
            GROUP = 0x00000001,
            ITEMSLIST = 0x00000002,
        }
    }
}
