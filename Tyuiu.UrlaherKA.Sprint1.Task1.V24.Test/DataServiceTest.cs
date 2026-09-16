using Tyuiu.UrlaherKA.Sprint1.Task1.V24.Lib;
namespace Tyuiu.UrlaherKA.Sprint1.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void Example()
        {
            double x, y;
            x = 9.0;
            y = 2.0;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(-2, res);
        }
    }
}
