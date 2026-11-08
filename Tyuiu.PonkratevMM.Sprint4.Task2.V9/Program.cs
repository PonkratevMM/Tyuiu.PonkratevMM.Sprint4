using Tyuiu.PonkratevMM.Sprint4.Task2.V9.Lib;
namespace Tyuiu.PonkratevMM.Sprint4.Task2.V9;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();

        Console.Title = "Спринт #4 | Выполнил Понкратьев М.М. | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #4                                         *");
        Console.WriteLine("* Тема: Одномерные массивы                          *");
        Console.WriteLine("* Задание #2                                        *");
        Console.WriteLine("* Вариант #9                                        *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 14         *");
        Console.WriteLine("* элементов, заполненный случайными числами в       *");
        Console.WriteLine("* диапазоне от 1 до 7. Подсчитать произведение      *");
        Console.WriteLine("* четных элементов массива.                         *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        int len = 14;
        int[] numsArry = new int[len];

        for (int i = 0; i < len; i++)
        {
            numsArry[i] = rnd.Next(1, 8);
        }

        Console.WriteLine("Массив:");
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine(numsArry[i] + "\t");
        }

        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");

        Console.WriteLine("Произведение четных элементов = " + ds.Calculate(numsArry));
        Console.ReadKey();
    }
}