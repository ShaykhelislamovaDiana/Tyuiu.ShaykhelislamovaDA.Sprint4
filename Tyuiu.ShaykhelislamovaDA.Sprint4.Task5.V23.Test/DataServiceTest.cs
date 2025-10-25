using Tyuiu.ShaykhelislamovaDA.Sprint4.Task5.V23.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint4.Task5.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] arr = new int[3, 3] { { -1, 2, -3 }, { -2, 2, 3 }, { 0, 2, 3 } };
            int[,] wait = new int[3, 3] { { 0, 2, 0 }, { 0, 2, 3 }, { 0, 2, 3 } };
            int[,] res = ds.Calculate(arr);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
