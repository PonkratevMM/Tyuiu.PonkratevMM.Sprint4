using Tyuiu.PonkratevMM.Sprint4.Task4.V28.Lib;
namespace Tyuiu.PonkratevMM.Sprint4.Task4.V28;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил Понкратьев М.М. | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #4                                         *");
        Console.WriteLine("* Тема: Двумерные массивы                           *");
        Console.WriteLine("* Задание #4                                        *");
        Console.WriteLine("* Вариант #28                                       *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5         *");
        Console.WriteLine("* элементов, заполненный значениями с клавиатуры    *");
        Console.WriteLine("* в диапазоне от 1 до 5. Заменить четные элементы   *");
        Console.WriteLine("* массива на 1.                                     *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        int rows = 5;
        int columns = 5;
        int[,] numsArray = new int[rows, columns];

        Console.WriteLine("Введите значения массива от 1 до 5:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"Введите numsArray[{i},{j}]:");
                numsArray[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine();
        Console.WriteLine("Исходный массив:");
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

        Console.WriteLine("Массив после замены четных элементов на 1:");
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