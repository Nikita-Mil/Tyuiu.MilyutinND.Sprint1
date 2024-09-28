using Tyuiu.MilyutinND.Sprint1.Task2.V13.Lib;

namespace Tyuiu.MilyutinND.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 6;
            var res = ds.ConvertMilesToKm(x);
            Assert.AreEqual(3.728, res);

        }
    }
}