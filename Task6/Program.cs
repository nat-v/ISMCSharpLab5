using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 4 == 0 && n % 100 != 0 || n % 400 == 0)
                Console.WriteLine("Год высокосный");
            else
                Console.WriteLine("Год не высокосный");
        }
    }
}
