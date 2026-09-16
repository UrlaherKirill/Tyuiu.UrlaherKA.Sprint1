using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.UrlaherKA.Sprint1.Task7.V26.Lib
{
    public class DataService : ISprint1Task7V26
    {
        public double Calculate(double x, double y)
        {
            double expression_1 = (Math.Sin(x * x) + y) / (y + 1);
            double expression_2 = (x * y - 12) / (34 + x * x);
            double res = expression_1 - expression_2;
            return Math.Round(res,3);
        }
    }
}
