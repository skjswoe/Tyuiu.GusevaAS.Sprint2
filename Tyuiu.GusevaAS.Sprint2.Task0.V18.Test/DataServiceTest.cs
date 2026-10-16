using Tyuiu.GusevaAS.Sprint2.Task0.V18.Lib;

namespace Tyuiu.GusevaAS.Sprint2.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5105;
            int y = 475;
            var res = ds.GetCompareOperations(x, y);
            bool[] wait = { false, true, true, true, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}