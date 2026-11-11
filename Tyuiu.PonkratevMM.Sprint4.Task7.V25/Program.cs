using Tyuiu.PonkratevMM.Sprint4.Task7.V25.Lib;
namespace Tyuiu.PonkratevMM.Sprint4.Task7.V25;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил Понкратьев М.М. | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #4                                         *");
        Console.WriteLine("* Тема: Двумерные массивы                           *");
        Console.WriteLine("* Задание #7                                        *");
        Console.WriteLine("* Вариант #25                                       *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Дана строка из одноразрядных цифр. Преобразуйте  *");
        Console.WriteLine("* ее в матрицу 4 на 3 и подсчитайте сумму четных   *");
        Console.WriteLine("* чисел.                                            *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        string value = "348561792486";
        int n = 4;
        int m = 3;

        int[,] matrix = new int[n, m];
        Console.WriteLine("Матрица 4 на 3:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = value[i * m + j] - '0';
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");

        Console.WriteLine("Сумма четных чисел в матрице = " + ds.Calculate(n, m, value));
        Console.ReadKey();
    }
}