using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.UrlaherKA.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            int FirstNum_x = (int)(x * 10) % 10;
            return FirstNum_x;
        }
    }
}
