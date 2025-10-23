using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShaykhelislamovaDA.Sprint4.Task4.V7.Lib
{
    public class DataService : ISprint4Task4V7
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;
            int strok = matrix.GetUpperBound(0) + 1;
            int stolb = matrix.Length / strok;
            for(int i = 0; i < strok; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    if (matrix[i, j] % 2 == 1)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
