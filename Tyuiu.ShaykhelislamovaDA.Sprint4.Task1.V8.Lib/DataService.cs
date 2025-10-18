using System.Runtime.InteropServices;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShaykhelislamovaDA.Sprint4.Task1.V8.Lib
{
    public class DataService : ISprint4Task1V8
    {
        public int Calculate(int[] array)
        {
            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    s += array[i];
                }
            }
            return s;
        }
    }
}
