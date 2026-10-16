using Tyuiu.GusevaAS.Sprint2.Task5.V11.Lib;

namespace Tyuiu.GusevaAS.Sprint2.Task5.V11.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("2026.3.1", ds.FindDateOfNextDay(2026, 2, 28));
            Assert.AreEqual("2026.5.1", ds.FindDateOfNextDay(2026, 4, 30));
            Assert.AreEqual("2027.1.1", ds.FindDateOfNextDay(2026, 12, 31));
            Assert.AreEqual("2026.1.2", ds.FindDateOfNextDay(2026, 1, 1));
            Assert.AreEqual("2026.3.15", ds.FindDateOfNextDay(2026, 3, 14));
        }
    }
}
