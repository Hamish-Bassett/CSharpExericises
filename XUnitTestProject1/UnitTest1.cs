namespace Basic4.Tests
{
    using System;
    using Xunit;
    using Basic4;


    /// <summary>
    /// Unit test to prove that the calculations are correct
    /// </summary>
    public class UnitTest1
    {
        Calculations basic4 = new Calculations();

        [Fact]
        public void TestFirstCalculation()
        {
            Assert.Equal(23, basic4.FirstCalculation());
        }
    }
}
