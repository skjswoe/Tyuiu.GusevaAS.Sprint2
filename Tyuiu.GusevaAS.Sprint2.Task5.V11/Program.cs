using Tyuiu.GusevaAS.Sprint2.Task5.V11.Lib;

namespace Tyuiu.GusevaAS.Sprint2.Task5.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Гусева А. С. | РППб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Гусева Алиса Степановна | РППб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
            Console.WriteLine("* g(год), m(порядковый номер месяца) и n(число).                          *");
            Console.WriteLine("* По заданным g, n и m определить дату следующего дня.                    *");
            Console.WriteLine("* Заданный год не является високосным.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите год g: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите месяц m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите день n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.FindDateOfNextDay(g, m, n));
            Console.ReadLine();
        }
    }
}
