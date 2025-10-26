using Tyuiu.ShaykhelislamovaDA.Sprint4.Task7.V3.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint4.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "12345678";
            int i = 4;
            int j = 2;
            int wait = 4;
            int res = ds.Calculate(i, j, str);
            Assert.AreEqual(wait, res);
        }
    }
}
