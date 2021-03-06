// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


namespace System.Resources
{
    public sealed partial class ResourceReader : System.IDisposable
    {
        [System.Security.SecurityCriticalAttribute]
        public ResourceReader(System.IO.Stream stream) { }
        public void Dispose() { }
        public System.Collections.IDictionaryEnumerator GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    }
    public sealed partial class ResourceWriter : System.IDisposable
    {
        public ResourceWriter(System.IO.Stream stream) { }
        public void AddResource(string name, string value) { }
        public void Dispose() { }
        public void Generate() { }
    }
}
