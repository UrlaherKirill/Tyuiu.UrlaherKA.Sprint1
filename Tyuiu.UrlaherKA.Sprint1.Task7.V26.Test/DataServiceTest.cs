using Tyuiu.UrlaherKA.Sprint1.Task7.V26.Lib;
namespace Tyuiu.UrlaherKA.Sprint1.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestExample()
        {
            double x = 1.0;
            double y = 2.0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(1.233, res);
        }
    }
}
