using Tyuiu.YurlovVN.Sprint2.Task4.V19.Lib;

namespace Tyuiu.YurlovVN.Sprint2.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(6.062, res);
        }
    }
}
