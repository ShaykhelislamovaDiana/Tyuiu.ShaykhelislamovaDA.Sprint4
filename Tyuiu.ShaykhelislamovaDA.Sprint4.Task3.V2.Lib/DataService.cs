using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShaykhelislamovaDA.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] array)
        {
            int stroki = array.GetUpperBound(0) + 1;
            int stolb = array.Length / stroki;
            int max = array[0, 0];
            for (int i = 1; i < stolb; i++)
            {
                if (array[0, i] > max)
                {
                    max = array[0, i];
                }
            }
            return max;
        }
    }
}
