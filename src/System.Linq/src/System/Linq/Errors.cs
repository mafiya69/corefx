// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Linq
{
    internal static class Error
    {
        internal static Exception ArgumentNull(string s) { return new ArgumentNullException(s); }

        internal static Exception ArgumentOutOfRange(string s) { return new ArgumentOutOfRangeException(s); }

        internal static Exception MoreThanOneElement() { return new InvalidOperationException(SR.MoreThanOneElement); }

        internal static Exception MoreThanOneMatch() { return new InvalidOperationException(SR.MoreThanOneMatch); }

        internal static Exception NoElements() { return new InvalidOperationException(SR.NoElements); }

        internal static Exception NoMatch() { return new InvalidOperationException(SR.NoMatch); }

        internal static Exception NotSupported() { return new NotSupportedException(); }
    }
}
