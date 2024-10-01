using Tyuiu.MilyutinND.Sprint1.Task6.V1;
using Tyuiu.MilyutinND.Sprint1.Task6.V1.Lib;

namespace Tyuiu.MilyutinND.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();

            var result = ds.SymbolCode("A");
            Assert.AreEqual("Символ: A Код: 65", result);

            result = ds.SymbolCode("1");
            Assert.AreEqual("Символ: 1 Код: 49", result);
        }
    }
}