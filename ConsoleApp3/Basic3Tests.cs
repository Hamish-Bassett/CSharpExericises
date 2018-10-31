using System;
using Xunit;

namespace XUnitTestProject1
{
    public class TestBasic3
    {
        [Fact]
        public void testAdd()
        {
            Assert.Equal(1, Add(0, 1));
        }

        public void testSubtract()
        {
            Assert.Equal(2, Add(4,-2)); 
        }           
    }
}
