// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.IO
{
    [Serializable]
    [TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public class EndOfStreamException : IOException
    {
        public EndOfStreamException()
            : base(SR.Arg_EndOfStreamException)
        {
            HResult = HResults.COR_E_ENDOFSTREAM;
        }

        public EndOfStreamException(string? message)
            : base(message ?? SR.Arg_EndOfStreamException)
        {
            HResult = HResults.COR_E_ENDOFSTREAM;
        }

        public EndOfStreamException(string? message, Exception? innerException)
            : base(message ?? SR.Arg_EndOfStreamException, innerException)
        {
            HResult = HResults.COR_E_ENDOFSTREAM;
        }

        [Obsolete(Obsoletions.LegacyFormatterImplMessage, DiagnosticId = Obsoletions.LegacyFormatterImplDiagId, UrlFormat = Obsoletions.SharedUrlFormat)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected EndOfStreamException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
