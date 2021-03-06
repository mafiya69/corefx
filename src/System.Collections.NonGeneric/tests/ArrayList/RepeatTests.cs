// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;

namespace System.Collections.Tests
{
    public class ArrayList_RepeatTests
    {
        [Fact]
        public void TestRepeatBasic()
        {
            ArrayList alst1;

            //[]Vanila test case - Repeat returns an ArrayList with the repeated object n times. 
            alst1 = ArrayList.Repeat(5, 1000);

            for (int i = 0; i < alst1.Count; i++)
            {
                Assert.Equal(5, (int)alst1[i]);
            }

            alst1 = ArrayList.Repeat(null, 10);

            for (int i = 0; i < alst1.Count; i++)
            {
                Assert.Null(alst1[i]);
            }

            alst1 = ArrayList.Repeat(5, 0);

            Assert.Equal(0, alst1.Count);

            //[]parm value
            //
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                {
                    alst1 = ArrayList.Repeat(5, -1);
                });
        }
    }
}
