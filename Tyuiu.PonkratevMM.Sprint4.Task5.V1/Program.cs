using Tyuiu.PonkratevMM.Sprint4.Task5.V1.Lib;
namespace Tyuiu.PonkratevMM.Sprint4.Task5.V1;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();

        Console.Title = "Спринт #4 | Выполнил Понкратьев М.М. | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #4                                         *");
        Console.WriteLine("* Тема: Двумерные массивы                           *");
        Console.WriteLine("* Задание #5                                        *");
        Console.WriteLine("* Вариант #1                                        *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5         *");
        Console.WriteLine("* элементов, заполненный случайными значениями в    *");
        Console.WriteLine("* диапазоне от -9 до 8. Заменить положительные      *");
        Console.WriteLine("* элементы массива на 1.                            *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        int rows = 5;
        int columns = 5;
        int[,] numsArray = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                numsArray[i, j] = rnd.Next(-9, 9);
            }
        }

        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(numsArray[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");

        int[,] result = ds.Calculate(numsArray);

        Console.WriteLine("Массив после замены положительных элементов на 1:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(result[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}