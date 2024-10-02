using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MilyutinND.Sprint1.Task7.V11.Lib
{
    public class DataService : ISprint1Task7V11
    {
        //Написать программу, которая вычисляет математическое выражение по
        //исходным значениям данных, вводимых пользователем. Ответ округлите до 3 знаков после запятой.
        public double Calculate(double x, double y)
        {
            //          (ln sinx)^x                            
            //  z = --------------------- + (y - √|x|)           
            //          ln(1 + x^2)
            double z = Math.Round((Math.Pow(Math.Log(Math.Sin(x)), x) / Math.Log(1 + x * x)) + (y - Math.Sqrt(Math.Abs(x))), 3);
            return z;
        }
    }
}
