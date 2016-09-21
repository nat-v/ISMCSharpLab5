using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            
            for (double i = 1; i >= 1 && i <= 50; i++)
            {
                sum += Math.Pow(і, (1 / і+1));
            }

            Console.WriteLine("Сумма = "+ sum);
        }
    }
}
