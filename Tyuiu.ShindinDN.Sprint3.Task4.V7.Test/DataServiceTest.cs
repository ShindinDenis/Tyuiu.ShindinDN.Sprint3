using Tyuiu.ShindinDN.Sprint3.Task4.V7.Lib;

namespace Tyuiu.ShindinDN.Sprint3.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-5, 5);
            double wait = 1231.499;
            Assert.AreEqual(res, wait);
        }
    }
}