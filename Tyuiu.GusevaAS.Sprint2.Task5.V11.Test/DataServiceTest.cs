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

            Assert.AreEqual("09.09.2023", ds.FindDateOfNextDay(2023, 9, 8));
            Assert.AreEqual("01.03.2026", ds.FindDateOfNextDay(2026, 2, 28));
            Assert.AreEqual("01.05.2026", ds.FindDateOfNextDay(2026, 4, 30));
            Assert.AreEqual("01.01.2027", ds.FindDateOfNextDay(2026, 12, 31));
            Assert.AreEqual("02.01.2026", ds.FindDateOfNextDay(2026, 1, 1));
        }
    }
}
