﻿using Tyuiu.MilyutinND.Sprint1.Task5.V6.Lib;
//Пусть k – целое от 1 до 365. Присвоить целой переменной n значение 1,2,...,7 в зависимости от того, на какой день
//недели (понедельник, вторник,..., воскресенье)приходится k-й день невисокосного года, в котором 1 января – понедельник.
Console.Title = "Спринт #1 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной n значение 1,2, *");
Console.WriteLine("* ...,7 в зависимости от того, на какой день недели (понедельник, втор-   *");
Console.WriteLine("* ник, ..., воскресенье ) приходится k-й день невисокосного года,         *");
Console.WriteLine("* в котором 1 января – понедельник.                                       *");
Console.WriteLine("***************************************************************************");


DataService ds  = new DataService();

Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите целое число k от 1 до 365: ");
if (int.TryParse(Console.ReadLine(), out int k))
{
    try
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int n = ds.Calculate(k);                    // Получаем день недели
        Console.WriteLine($"k-й день года соответствует: {n} день недели.");
        switch (n)
        {
            case 1:
                Console.WriteLine("Понедельник"); break;
            case 2:
                Console.WriteLine("Вторник"); break;
            case 3:
                Console.WriteLine("Среда"); break;
            case 4:
                Console.WriteLine("Четверг"); break;
            case 5:
                Console.WriteLine("Пятница"); break;
            case 6:
                Console.WriteLine("Суббота"); break;
            case 7:
                Console.WriteLine("Воскресенье"); break;
        }
    }
    catch (ArgumentOutOfRangeException e) //обработчик исключений. Если для созданного исключения не существует обработчиков, выполнение программы прекращается с сообщением об ошибке.
    {
        Console.WriteLine(e.Message);
    }
}
else
{
    Console.WriteLine("Ощибка, введите целое число.");
}