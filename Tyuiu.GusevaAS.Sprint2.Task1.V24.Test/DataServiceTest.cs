using Tyuiu.GusevaAS.Sprint2.Task1.V24.Lib;

namespace Tyuiu.GusevaAS.Sprint2.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 325, b = 325, c = 242, d = 324;
            var res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = { true, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
