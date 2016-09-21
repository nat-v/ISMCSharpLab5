using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double sum = 1;
            double a = 0;
            for (double i = 1; i <= 10; i++)
            {
                a = (i + 1) / (i + 2) * Math.Pow(2, i);
                if (i % 2 == 1) // i число не парное, перед слагаемым знак -
                {
                    a *= -1;                    
                }         
               
                sum += a;
            }

            Console.WriteLine("Сумма = "+ sum);

        }
    }
}
