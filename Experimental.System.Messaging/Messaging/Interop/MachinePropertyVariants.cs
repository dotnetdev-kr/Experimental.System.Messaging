//------------------------------------------------------------------------------
// <copyright file="MachinePropertyVariants.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------

namespace Experimental.System.Messaging.Interop
{
    internal class MachinePropertyVariants : MessagePropertyVariants
    {
        public MachinePropertyVariants()
            : base(5, NativeMethods.MACHINE_BASE + 1)
        {
        }
    }
}
