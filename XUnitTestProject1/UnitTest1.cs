using System;
using Xunit;

namespace Basic4.Tests
{
    public class UnitTest1
    {
        
        [Fact]
        public void TestFirstCalculation()
        {
            Assert.Equal(FirstCalculation(), 23);
        }
    }
}
