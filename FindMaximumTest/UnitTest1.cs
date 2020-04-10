using NUnit.Framework;
using FindMaximum;

namespace FindMaximumTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenThreeIntgers_ShouldReturnMaximum()
        {
            int expected = 9;
            int num1 = 4,
                num2 = 9,
                num3 = 6;
            Program findMaximum = new Program();
            int maximum = findMaximum.IntegerMaximum(num1, num2, num3);
            Assert.AreEqual(expected, maximum);
        }
    }
}