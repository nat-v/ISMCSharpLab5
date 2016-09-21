using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int x = int.Parse(Console.ReadLine());

            int a = x / 100; //сотни
            int b = (x / 10) % 10; //десятки
            int c = x % 10; //единицы

            Console.WriteLine("Результат: {0}{1}{2}", a, c, b);
        }
    }
}
