using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PonkratevMM.Sprint4.Task3.V16.Lib
{
    public class DataService : ISprint4Task3V16
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int lastColumn = columns - 1;

            int min = array[0, lastColumn];

            for (int i = 1; i < rows; i++)
            {
                if (array[i, lastColumn] < min)
                {
                    min = array[i, lastColumn];
                }
            }
            return min;
        }
    }
}
