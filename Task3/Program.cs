﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int x = int.Parse(Console.ReadLine());

            int a = x / 100; //сотни
            int b = (x / 10) %10; //десятки
            int c = x % 10; //единицы
            int summ = a + b + c; //сумма
            int mul = a * b * c; //произведение

            Console.WriteLine("Количество сотень = {0}\nКоличество десятков = {1}\nКоличество единиц = {2}\nСумма цифр = {3}\nПроизведение цифр = {4}\n", a, b, c, summ, mul);
        }
    }
}
