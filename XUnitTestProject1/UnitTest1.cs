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
        [Fact]
        public void TestSecondCalculation()
        {
            Assert.Equal(5, basic4.SecondCalculation());
        }
        [Fact]
        public void TestThridCalculation()
        {
            Assert.Equal(12, basic4.ThirdCalculation());
        }
        [Fact]
        public void TestFourthCalculation()
        {
            Assert.Equal(3, basic4.FourthCalculation());
        }
    }
}
