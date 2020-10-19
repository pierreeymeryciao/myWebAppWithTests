using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(3, 1);
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(1, 2);
        }
    }
}
