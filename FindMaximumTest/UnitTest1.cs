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
            MaxValue findMaximum = new MaxValue();
            int maximum = findMaximum.IntegerMaximum(num1, num2, num3);
            Assert.AreEqual(expected, maximum);
        }

        [Test]
        public void GivenThreeFloats_ShouldReturnMaximum()
        {
            float expected = 15.23F;
            float num1 = 12.6F,
                num2 = 4.8F,
                num3 = 15.23F;
            MaxValue findMaximum = new MaxValue(); ;
            float maximum = findMaximum.FloatMaximum(num1, num2, num3);
            Assert.AreEqual(expected, maximum);
        }

        [Test]
        public void GivenThreeStrings_ShouldReturnMaximum()
        {
            string expected = "Peter";
            string str1 = "John",
                str2 = "Peter",
                str3 = "Angel";
            MaxValue findMaximum = new MaxValue();
            string maximum = findMaximum.StringMaximum(str1, str2, str3);
            Assert.AreEqual(expected, maximum);
        }

        [Test]
        public void GivenThreeGenericType_ShouldReturnMaximum()
        {
            int expected = 9;
            int num1 = 4,
                num2 = 9,
                num3 = 6;
            FindMaximum<int> findMaximum = new FindMaximum<int>();
            int maximum = findMaximum.TestMaximum(num1, num2, num3);
            Assert.AreEqual(expected, maximum);
        }
    }
}