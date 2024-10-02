using Tyuiu.MilyutinND.Sprint1.Task7.V11.Lib;

Console.Title = "Спринт #1 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите      *");
Console.WriteLine("* до 3 знаков после запятой.                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("*          (ln sinx)^x                                                    *");
Console.WriteLine("*  z = --------------------- + (y - √|x|)                                 *");
Console.WriteLine("*          ln(1 + x^2)                                                    *");

double x, y;

Console.WriteLine("Введите значение Х: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение Y: ");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(x, y));
Console.ReadKey();