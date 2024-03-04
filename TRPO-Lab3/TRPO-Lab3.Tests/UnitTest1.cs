using TRPO_Lab3.Lib;

namespace TRPO_Lab3.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double area = CalculateArea.CalculateConeArea(10, 10);
            double expected = 758.448;
            Assert.Greater(area, expected - 0.001);
            Assert.Greater(expected + 0.001, area);
        }

        [Test]
        public void Test2()
        {
            double area = CalculateArea.CalculateConeArea(20, 10);
            double expected = 2661.6;
            Assert.Greater(area, expected - 0.001);
            Assert.Greater(expected + 0.001, area);
        }

        [Test]
        public void Test3()
        {
            Assert.Throws(typeof(ArgumentException) ,() => { CalculateArea.CalculateConeArea(-10, 10); });
            Assert.Throws(typeof(ArgumentException), () => { CalculateArea.CalculateConeArea(10, -10); });
            Assert.Throws(typeof(ArgumentException), () => { CalculateArea.CalculateConeArea(-10, -10); });
        }
    }
}