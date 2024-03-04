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
    }
}