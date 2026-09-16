using Tyuiu.UrlaherKA.Sprint1.Task6.V9.Lib;
namespace Tyuiu.UrlaherKA.Sprint1.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TextTest()
        {
            string Text = "Hello World";
            string res = ds.MoveLetterToStart(Text);
            Assert.AreEqual("oHell dWorl", res);

        }
    }
}
