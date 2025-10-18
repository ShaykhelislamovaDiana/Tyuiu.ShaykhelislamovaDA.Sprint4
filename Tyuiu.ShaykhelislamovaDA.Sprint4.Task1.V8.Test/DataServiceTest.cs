using Tyuiu.ShaykhelislamovaDA.Sprint4.Task1.V8.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint4.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] arr = new int[12];
            arr[1] = 1;
            arr[2] = 2;
            arr[3] = 3;
            arr[4] = 4;
            arr[5] = 5;
            arr[6] = 6;
            arr[7] = 7;
            arr[8] = 8;
            arr[9] = 9;
            arr[10] = 10;
            arr[11] = 11;
            arr[12] = 12;
            int wait = 36;
            int res = ds.Calculate(arr);
            Assert.AreEqual(wait, res);
        }
    }
}
