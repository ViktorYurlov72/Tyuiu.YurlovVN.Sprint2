using Tyuiu.YurlovVN.Sprint2.Task2.V10.Lib;

namespace Tyuiu.YurlovVN.Sprint2.Task2.V10.Test
{
    [TestClass]
    public class AreaServiceTests
    {
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 3;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}