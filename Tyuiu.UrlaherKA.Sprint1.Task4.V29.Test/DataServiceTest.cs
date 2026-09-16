using Tyuiu.UrlaherKA.Sprint1.Task4.V29.Lib;
namespace Tyuiu.UrlaherKA.Sprint1.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void FormulaCheck()
        {
            double x = 4.0;
            double y = 1.0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0.167, res);

        }
    }
}
