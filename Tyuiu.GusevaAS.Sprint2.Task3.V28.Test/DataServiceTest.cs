using Tyuiu.GusevaAS.Sprint2.Task3.V28.Lib;

namespace Tyuiu.GusevaAS.Sprint2.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 0;
            var res = ds.Calculate(x);
            Assert.AreEqual(-5, res);
        }
    }
}
