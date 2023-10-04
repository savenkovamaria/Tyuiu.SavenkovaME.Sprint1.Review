using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint1.TaskReview.V30.Lib;

namespace Tyuiu.SavenkovaME.Sprint1.TaskReview.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание Спринт1Ревью                                                    *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("*                            sin(x^5) + x^3     y^5                       *");
            Console.WriteLine("* и вычисляет   z= x + e^x + --------------  + ----- и печатает           *");
            Console.WriteLine("*                                 3^x           5^y                       *");
            Console.WriteLine("*  результат на экране.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите число Х:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число У:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение выражения = " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
