using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BotterVV.Sprint1.Task2.V22.Lib;

namespace Tyuiu.BotterVV.Sprint1.Task2.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds2 = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Боттер В.В. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Боттер Вадим Валерьевич | ПКТб-23-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* считает среднее значение чисел и печатает результат на экране.          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x, y, z;
            Console.WriteLine("Введите первое число: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds2.CalculateAVGValue(x, y, z));
            Console.ReadKey();
        }
    }
}
