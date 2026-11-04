using Tyuiu.PonkratevMM.Sprint4.Task1.V26.Lib;
namespace Tyuiu.PonkratevMM.Sprint4.Task1.V26;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int len = 10;
        int[] array = new int[len];

        Console.Title = "Спринт #4 | Выполнил Понкратьев М.М. | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #4                                         *");
        Console.WriteLine("* Тема: Одномерные массивы                          *");
        Console.WriteLine("* Задание #1                                        *");
        Console.WriteLine("* Вариант #26                                       *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Подсчитать сумму нечетных элементов массива.      *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        Console.WriteLine("Введите " + len + " элементов массива (0..8):");
        for (int i = 0; i < len; i++)
        {
            Console.Write("array[" + i + "] = ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Массив:");
        for (int i = 0; i < len; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();

        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");

        Console.WriteLine("Сумма нечетных элементов = " + ds.Calculate(array));
        Console.ReadKey();
    }
}