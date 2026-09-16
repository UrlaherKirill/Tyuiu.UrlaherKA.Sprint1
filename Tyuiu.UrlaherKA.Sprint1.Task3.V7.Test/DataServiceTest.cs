using Tyuiu.UrlaherKA.Sprint1.Task3.V7.Lib;
namespace Tyuiu.UrlaherKA.Sprint1.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckVertsToKilometrs()
        {
            double x = 100.0;
            double res = ds.VerstsToKilometers(x);
            Assert.AreEqual(106.68, res);
        }
    }
}
