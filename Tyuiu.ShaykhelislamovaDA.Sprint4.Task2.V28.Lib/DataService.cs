using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShaykhelislamovaDA.Sprint4.Task2.V28.Lib
{
    public class DataService : ISprint4Task2V28
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            for (int i = 0; i<array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
