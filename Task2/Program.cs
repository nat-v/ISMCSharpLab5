using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число а: ");
            double a = double.Parse(Console.ReadLine());
            double a2, a4, a5, a6, a7, a8, a9, a10, a13, a15, a16, a21, a28, a64;
            a4 = a * a;          
            a4 *= a4;

            a2 = a * a;
            a6 = a2 * a2 * a2;
           
            a7 = a6*a;

            a8 = a2; 
            a8 *= a8; //a4
            a8 *= a8; //a8

            a9 = a8 * a;

            a10 = a2;
            a10 *= a10; //a4
            a10 *= a10; //a8
            a10 = a10 * a2; //a10

            a13 = a6 * a6 * a; //a6 - 3 операции

            a5 = a2 * a2 * a; // 3 операции
            a15 = a5 * a5 * a5; // 6

            a21 = a10 * a10 * a; //a10 - 4 операции + 2

            a16 = a8*a8 ; //a8 - 3 операции + 1 = 4
            a28 = a16 * a8; // a24 = 5 операций
            a28 = a28 * a4;

            a64 = a16; //a16 - 4 операции
            a64 = a16 * a16; //32 - 5 операций
            a64 *= a64;

            Console.WriteLine(" a4 = {0}\n a6 = {1}\n a7 = {2}\n a8 = {3}\n a9 = {4}\n a10 = {5}\n a13 = {6}\n a15 = {7}\n a21 = {8}\n a28 = {9}\n a64 = {10}\n", + a4, + a6, + a7, + a8, + a9, + a10, + a13, + a15, + a21, + a28, + a64);     


        }
    }
}
