﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KoptyaevRS.Sprint1.Task4.V29.Lib;

namespace Tyuiu.KoptyaevRS.Sprint1.Task4.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Коптяев Р. С. | АСОиУБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #29                                                              *");
            Console.WriteLine("* Выполнил: Коптяев Рустам Сергеевич | АСОиУБ-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("((2+|x-2*y|)^0.5)/(3*x*y^2) = " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
