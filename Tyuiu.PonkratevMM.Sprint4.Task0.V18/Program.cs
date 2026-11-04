using Tyuiu.PonkratevMM.Sprint4.Task0.V18.Lib;

namespace Tyuiu.PonkratevMM.Sprint4.Task0.V18;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил Понкратьев М.М | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #4                                         *");
        Console.WriteLine("* Тема: Одномерные массивы                          *");
        Console.WriteLine("* Задание #0                                        *");
        Console.WriteLine("* Вариант #18                                       *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Подсчитать сумму нечетных элементов массива.      *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

        Console.WriteLine("Массив: 9, 8, 7, 6, 5, 7, 3, 2, 7, 3");

        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");

        Console.WriteLine("Сумма нечетных элементов = " + ds.GetSumOddArrEl(array));
        Console.ReadKey();
    }
}