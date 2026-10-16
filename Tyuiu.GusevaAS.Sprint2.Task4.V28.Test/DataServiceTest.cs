using Tyuiu.GusevaAS.Sprint2.Task4.V28.Lib;

namespace Tyuiu.GusevaAS.Sprint2.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.014, res);
        }
    }
}
