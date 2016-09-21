using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            double sum = 1;
            double a = 0;        

            for (double i = 1; i <= n; i++)
            {
                a += 1 / i;
                if (i % 2 == 1)
                {
                    a *= -1;
                }
                sum += a;
            }

            Console.WriteLine("Расстояние от дома: "+ a);
            Console.WriteLine("Общий путь:"+ sum);
        }
    }
}
