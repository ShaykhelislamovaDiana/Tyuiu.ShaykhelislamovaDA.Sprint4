using Tyuiu.ShaykhelislamovaDA.Sprint4.Task6.V8.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint4.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] arr = { "Суп", "Несуп", "Nu maaaam", "Oi" };
            string[] wait = { "Несуп", "Nu maaaam" };
            string[] res = ds.Calculate(arr);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
