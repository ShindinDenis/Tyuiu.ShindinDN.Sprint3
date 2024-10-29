using Tyuiu.ShindinDN.Sprint3.Task6.V28.Lib;

namespace Tyuiu.ShindinDN.Sprint3.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            int startValue = 13;
            int stopValue = 19;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(15, res);
        }
    }
}