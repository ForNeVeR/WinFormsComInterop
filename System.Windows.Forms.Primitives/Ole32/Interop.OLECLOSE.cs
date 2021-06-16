﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

public static partial class Interop
{
    public static partial class Ole32
    {
        public enum OLECLOSE : uint
        {
            SAVEIFDIRTY = 0,
            NOSAVE = 1,
            PROMPTSAVE = 2
        }
    }
}
