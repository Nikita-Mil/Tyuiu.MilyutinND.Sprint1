using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MilyutinND.Sprint1.Task4.V1.Lib
{
    public class DataService : ISprint1Task4V1
    {
        public double Calculate(double x)
        {
            //Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат
            //по формуле и печатает его на экране. Ответ округлите до 3 знаков после запятой.
            //Формула:
            //             1
            //     -----------------
            //        ( x + 2 )^2
            var res = Math.Round(1 / Math.Pow((x + 2), 2), 3);
            return res;
        }
    }
}
