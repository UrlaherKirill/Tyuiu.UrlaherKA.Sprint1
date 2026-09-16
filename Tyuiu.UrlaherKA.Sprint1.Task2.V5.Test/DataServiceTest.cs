using Tyuiu.UrlaherKA.Sprint1.Task2.V5.Lib;
namespace Tyuiu.UrlaherKA.Sprint1.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void SquareCube()
        {
            int x = 5;
            int Square = ds.CalculateSideSquare(x);
            Assert.AreEqual(25, Square);
        }
    }
}
