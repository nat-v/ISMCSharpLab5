using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение х: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение y: ");
            double y = double.Parse(Console.ReadLine());
            double a = Math.Pow(x, 2);
            double b = Math.Sqrt(Math.Pow(x, 2) + 10);
            double c = y + 1 / b;
            double d = x + (2 + y) / a;
            double e = y + 1 / b;
            if (a != 0 && b != 0 && c != 0)
            {
                double z = d / e;
                double q = 2.8 * Math.Sin(x) + Math.Abs(y);
                Console.WriteLine("z = " + z);
                Console.WriteLine("q = " + q); 
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя");
            }
                         

        }
    }
}
