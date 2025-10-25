using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShaykhelislamovaDA.Sprint4.Task6.V8.Lib
{
    public class DataService : ISprint4Task6V8
    {
        public string[] Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, len => len.Length > 4);
            return res;
        }
    }
}
