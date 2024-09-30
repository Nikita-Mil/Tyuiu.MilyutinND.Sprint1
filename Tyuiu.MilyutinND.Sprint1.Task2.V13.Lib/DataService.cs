using System;
using tyuiu.cources.programming.interfaces.Sprint1;
//Формулировка задания: Известно расстояние в милях. Вычислить расстояние в километрах. Ответ округлите до 3 знаков после запятой.

namespace Tyuiu.MilyutinND.Sprint1.Task2.V13.Lib
{
    public class DataService : ISprint1Task2V13
    {
        public double ConvertMilesToKm(int value)
        {
            return value * 0.621;
        }
    }
}
