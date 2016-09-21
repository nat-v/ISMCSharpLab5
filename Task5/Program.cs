using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число n = ");
            int n = int.Parse(Console.ReadLine());

            int a = n / 100; //сотни
            int b = (n / 10) % 10; //десятки
            int c = n % 10; //единицы
            int x = b * 100 + a * 10 + c;

            if (b == 0)
                Console.WriteLine("Число десятков не должно быть равно 0");
            else            
                Console.WriteLine("x = {0} ", x);
            
        }
    }
}
