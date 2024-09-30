using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MilyutinND.Sprint1.Task3.V16.Lib
{
    public class DataService : ISprint1Task3V16
    {
        public double CoeffOfQuadraticEquation(double x1, double x2)
        {
            //Написать программу, которая вычисляет и печатает коэффициент приведенного квадратного уравнения,
            //корнями которого являются введенные пользователем два вещественных числа (для справки: b=-x1-x2). Ответ округлите до 3 знаков после запятой.
            double b = -x1 - x2;
            return Math.Round(b, 3);
        }
    }
}
