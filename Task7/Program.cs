using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер достоинства карты: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введите номер масти: ");
            int m = int.Parse(Console.ReadLine());
            

            switch (k)
            {
                case 6:
                    Console.Write("Шестёрка ");
                    break;
                case 7:
                    Console.Write("Семёрка ");
                    break;
                case 8:
                    Console.Write("Восьмёрка ");
                    break;
                case 9:
                    Console.Write("Девятка ");
                    break;
                case 10:
                    Console.Write("Десятка ");
                    break;
                case 11:
                    Console.Write("Валет ");
                    break;
                case 12:
                    Console.Write("Дама ");
                    break;
                case 13:
                    Console.Write("Король ");
                    break;
                case 14:
                    Console.Write("Туз ");
                    break;
                default:
                    Console.WriteLine("Такой карты нету.");
                    
                    break;                   
            }
            

            switch (m)
            {
                case 1:
                    Console.WriteLine("пик");
                    break;
                case 2:
                    Console.WriteLine("треф");
                    break;
                case 3:
                    Console.WriteLine("бубен");
                    break;
                case 4:
                    Console.WriteLine("червей");
                    break;
                default:
                    Console.WriteLine("Такой масти нету.");
                    break;
            }
            



        }
                    }

            }
            
        

