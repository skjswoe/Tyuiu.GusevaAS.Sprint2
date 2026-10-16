using Tyuiu.GusevaAS.Sprint2.Task7.V11.Lib;

namespace Tyuiu.GusevaAS.Sprint2.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(0.5, 0));
            Assert.IsTrue(ds.CheckDotInShadedArea(0, -0.5));
            Assert.IsTrue(ds.CheckDotInShadedArea(-0.5, -0.5));

            Assert.IsFalse(ds.CheckDotInShadedArea(0.5, 0.8));
            Assert.IsFalse(ds.CheckDotInShadedArea(2, 2));
            Assert.IsFalse(ds.CheckDotInShadedArea(-1.5, -1.5));
        }
    }
}
