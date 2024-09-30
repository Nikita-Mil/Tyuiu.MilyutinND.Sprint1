﻿//Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат
//по формуле и печатает его на экране. Ответ округлите до 3 знаков после запятой.
//Формула:
//             1
//     -----------------
//        ( x + 2 )^2
using Tyuiu.MilyutinND.Sprint1.Task4.V1.Lib;

Console.Title = "Спринт #1 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#. Class Math                            *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.Ответ округлите *");
Console.WriteLine("* до 3 знаков после запятой.                                              *");
Console.WriteLine("* Формула:                                                                *");
Console.WriteLine("*           1                                                             *");
Console.WriteLine("*   -----------------                                                     *");
Console.WriteLine("*      ( x + 2 )^2                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x;
Console.WriteLine("Введите значение X:");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(" 1 / (x + 2)^2 = " + ds.Calculate(x));
Console.ReadKey();
