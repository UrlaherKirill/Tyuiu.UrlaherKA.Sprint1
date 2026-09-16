using Tyuiu.UrlaherKA.Sprint1.Task5.V5.Lib;
namespace Tyuiu.UrlaherKA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            double x = 32.567;
            int res = ds.Calculate(x);
            Assert.AreEqual(5, res);
        }
    }
}
