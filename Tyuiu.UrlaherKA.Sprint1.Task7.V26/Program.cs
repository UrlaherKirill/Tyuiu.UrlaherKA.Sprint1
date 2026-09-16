using Tyuiu.UrlaherKA.Sprint1.Task7.V26.Lib;
namespace Tyuiu.UrlaherKA.Sprint1.Task7.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("       sin(x*x) + y         x * y - 12               ");
            Console.WriteLine("z =    ------------    -    -----------              ");
            Console.WriteLine("         y + 1              34 + x * x               ");

            double x, y, z;

            Console.WriteLine("Введите x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            y = Convert.ToDouble(Console.ReadLine());

            z = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Выражение z = {z}");

        }
    }
}
