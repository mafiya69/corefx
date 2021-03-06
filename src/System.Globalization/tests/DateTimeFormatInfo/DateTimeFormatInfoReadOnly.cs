// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Globalization;
using Xunit;

namespace System.Globalization.Tests
{
    public class DateTimeFormatInfoReadOnly
    {
        // PosTest1: Call ReadOnly on a writable DateTimeFormatInfo instance
        [Fact]
        public void TestWritable()
        {
            DateTimeFormatInfo info = new DateTimeFormatInfo();
            DateTimeFormatInfo actual = DateTimeFormatInfo.ReadOnly(info);

            Assert.True(actual.IsReadOnly);
        }

        // PosTest2: Call ReadOnly on a read only DateTimeFormatInfo instance
        [Fact]
        public void TestReadOnly()
        {
            DateTimeFormatInfo info = DateTimeFormatInfo.InvariantInfo;
            DateTimeFormatInfo actual = DateTimeFormatInfo.ReadOnly(info);

            Assert.True(actual.IsReadOnly);
        }

        // NegTest1: ArgumentNullException should be thrown when dtfi is a null reference
        [Fact]
        public void TestNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                DateTimeFormatInfo.ReadOnly(null);
            });
        }
    }
}
