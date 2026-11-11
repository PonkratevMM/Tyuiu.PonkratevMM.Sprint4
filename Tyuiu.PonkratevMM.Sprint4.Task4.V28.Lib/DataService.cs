using tyuiu.cources.programming.interfaces.Sprint4;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.PonkratevMM.Sprint4.Task4.V28.Lib
{
    public class DataService : ISprint4Task4V28
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] result = (int[,])matrix.Clone();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (result[i, j] % 2 == 0)
                    {
                        result[i, j] = 1;
                    }
                }
            }
            return result;
        }
    }
}
