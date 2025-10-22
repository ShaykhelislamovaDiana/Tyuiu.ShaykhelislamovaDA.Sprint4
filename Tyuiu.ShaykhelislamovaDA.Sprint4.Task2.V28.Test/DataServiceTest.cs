using Tyuiu.ShaykhelislamovaDA.Sprint4.Task2.V28.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint4.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] arr = new int[12];
            for(int i = 0; i<12; i++)
            {
                arr[i] = i;
            }
            int wait = 36;
            int res = ds.Calculate(arr);
            Assert.AreEqual(wait, res);
        }
    }
}
