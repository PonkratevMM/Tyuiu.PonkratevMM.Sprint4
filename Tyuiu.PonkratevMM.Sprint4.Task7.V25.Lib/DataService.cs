using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PonkratevMM.Sprint4.Task7.V25.Lib
{
    public class DataService : ISprint4Task7V25
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = value[i * m + j] - '0';
                }
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
