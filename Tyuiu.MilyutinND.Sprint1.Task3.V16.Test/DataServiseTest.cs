using Tyuiu.MilyutinND.Sprint1.Task3.V16.Lib;

namespace Tyuiu.MilyutinND.Sprint1.Task3.V16.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression() // проверка выражения
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = -5;
            var res = ds.CoeffOfQuadraticEquation(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}