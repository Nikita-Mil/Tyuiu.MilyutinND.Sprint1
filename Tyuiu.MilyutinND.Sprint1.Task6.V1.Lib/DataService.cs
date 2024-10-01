using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MilyutinND.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
            char x = value[0];            //длля символа какоголибо
            int cod = x;                  //целое число
            return $"Символ: {x} Код: {cod}";
        }
    }
}
