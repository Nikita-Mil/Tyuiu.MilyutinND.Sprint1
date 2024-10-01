using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MilyutinND.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            //Пусть k – целое от 1 до 365. Присвоить целой переменной n значение 1,2,...,7 в зависимости от того, на какой день
            //недели (понедельник, вторник,..., воскресенье)приходится k-й день невисокосного года, в котором 1 января – понедельник.
            //1 января – понедельник.
            if (k < 1 || k > 365)
            {
                throw new ArgumentOutOfRangeException(nameof(k), "k дожно быть от 1 до 365.");// генерируется, если значение аргумента находится вне диапазона допустимых значений
            }
            int[] n = [0, 1, 2, 3, 4, 5, 6, 7];
            return n[((k - 1) % 7) + 1];
        }
    }
}
