// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// ------------------------------------------------------------------------------
// Changes to this file must follow the https://aka.ms/api-review process.
// ------------------------------------------------------------------------------

// The compiler emits a reference to the internal copy of this type in our non-NETCoreApp assembly
// so we must include a forward to be compatible with libraries compiled against non-NETCoreApp Microsoft.Extensions.Caching.Abstractions
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Runtime.CompilerServices.IsExternalInit))]

namespace Microsoft.Extensions.Caching.Memory
{
    public partial interface IMemoryCache : System.IDisposable
    {
        MemoryCacheStatistics? GetCurrentStatistics() => null;
    }
}