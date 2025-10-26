using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShaykhelislamovaDA.Sprint4.Task7.V3.Lib
{
    public class DataService : ISprint4Task7V3
    {
        public int Calculate(int n, int m, string value)
        {
            int ind = 0;
            int count = 0;
            int[,] arr = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = Convert.ToInt32(value[ind]);
                    ind++;
                }
            }
            for(int i = 0; i < n;i++)
            {
                for(int j = 0;j < m;j++)
                {
                    if (arr[i,j] % 2 == 1)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
