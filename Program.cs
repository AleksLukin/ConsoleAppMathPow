using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для которого необходимо вычислить его квадрат: ");
            int mathPow=int.Parse(Console.ReadLine());

            int increment = 1;
            int result;
            
            for (int i = 0; i <= mathPow; i++)
            {
                if (mathPow == 1)
                {
                    increment = (2 * increment) - 1;
                }
                else
                {
                    result = (2 * i) - 1; 

                    increment = result +increment;      
                }
            }            
            Console.Write($"Квадрат числа {mathPow} равен: {increment}");

            Console.ReadLine();
        }
    }
}
