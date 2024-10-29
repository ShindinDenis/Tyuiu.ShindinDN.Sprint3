using Tyuiu.ShindinDN.Sprint3.Task3.V9.Lib;

namespace Tyuiu.ShindinDN.Sprint3.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string res = ds.ReplaceNumOnChar("56hy vfe4r4 vf45b", 'w');
            string wait = "wwhy vfewrw vfwwb";
            Assert.AreEqual(wait, res);
        }
    }
}