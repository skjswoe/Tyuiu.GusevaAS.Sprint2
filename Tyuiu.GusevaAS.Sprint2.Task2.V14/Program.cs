using Tyuiu.GusevaAS.Sprint2.Task2.V14.Lib;

namespace Tyuiu.GusevaAS.Sprint2.Task2.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Гусева А. С. | РППб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Гусева Алиса Степановна | РППб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X, Y                      *");
            Console.WriteLine("* в заштрихованной области.                                               *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите координату x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (ds.CheckDotInShadedArea(x, y))
                Console.WriteLine("Точка находится в заштрихованной области");
            else
                Console.WriteLine("Точка НЕ находится в заштрихованной области");

            Console.ReadLine();
        }
    }
}