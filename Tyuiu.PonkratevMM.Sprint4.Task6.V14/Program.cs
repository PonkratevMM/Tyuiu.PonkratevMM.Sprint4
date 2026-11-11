using Tyuiu.PonkratevMM.Sprint4.Task6.V14.Lib;
namespace Tyuiu.PonkratevMM.Sprint4.Task6.V14;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил Понкратьев М.М. | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #4                                         *");
        Console.WriteLine("* Тема: Одномерные массивы                          *");
        Console.WriteLine("* Задание #6                                        *");
        Console.WriteLine("* Вариант #14                                       *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Дан строковый массив данных. Используя класс     *");
        Console.WriteLine("* Array, выведите элементы массива, длина которых  *");
        Console.WriteLine("* больше 3 символов.                                *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < months.Length; i++)
        {
            Console.WriteLine(months[i]);
        }

        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");

        string[] result = ds.Calculate(months);

        Console.WriteLine("Элементы массива, длина которых больше 3 символов:");
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }

        Console.ReadKey();
    }
}