using Tyuiu.PonkratevMM.Sprint4.Task3.V16.Lib;
namespace Tyuiu.PonkratevMM.Sprint4.Task3.V16;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил Понкратьев М.М. | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #4                                         *");
        Console.WriteLine("* Тема: Двумерные массивы                           *");
        Console.WriteLine("* Задание #3                                        *");
        Console.WriteLine("* Вариант #16                                       *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5        *");
        Console.WriteLine("* элементов, заполненный статическими значениями    *");
        Console.WriteLine("* в диапазоне от 1 до 9. Найти минимальный элемент  *");
        Console.WriteLine("* в последнем столбце массива.                      *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        int[,] numsArray = new int[5, 5]
        {
            {5, 8, 5, 8, 4},
            {2, 3, 4, 6, 3},
            {1, 1, 2, 9, 9},
            {6, 7, 4, 1, 2},
            {5, 7, 1, 8, 7}
        };

        Console.WriteLine("Массив:");
        for (int i = 0; i < numsArray.GetLength(0); i++)
        {
            for (int j = 0; j < numsArray.GetLength(1); j++)
            {
                Console.Write(numsArray[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");

        Console.WriteLine("Минимальный элемент в последнем столбце = " + ds.Calculate(numsArray));
        Console.ReadKey();
    }
}