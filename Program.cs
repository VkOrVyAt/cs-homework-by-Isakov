using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics.SymbolStore;
using System.Dynamic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Test
{
    internal class Program
    {
        public static void CreateArray()
        {
            Random random = new Random();
            Console.WriteLine("Write lenght");
            int lenght = int.Parse(Console.ReadLine());
            if (lenght == 0) Console.WriteLine("Array can't be with lenght 0");
            else
            {
                int[] array = new int[lenght];
                for (int i = 0; i < array.Length; i++) array[i] = random.Next(100);
                foreach (int item in array)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static void sumDigits(int number)
        {
            int sum = 0;
            if (number == 0) Console.WriteLine("0");
            else
            {
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                Console.WriteLine(sum);
            }
        }
        public static void exponentiation(double basic , int power)
        {
            if (basic == 0 && power == 0) Console.WriteLine("Eror");
            else if (power == 0) Console.WriteLine("1");
            else 
            {
                var result = 1.00;
                var i = 0;
                while (i < power)
                {
                    result *= basic;
                    i++;
                }
                Console.WriteLine(result);
            }
        }
        public static void Main()
        {
            //Console.WriteLine("write including number");
            //var includNumber = double.Parse(Console.ReadLine());    
            //Console.WriteLine("write Power of natural number");
            //int powerMath = int.Parse(Console.ReadLine());
            //exponentiation(includNumber, powerMath);
            //Console.WriteLine("write number");
            //int number = int.Parse(Console.ReadLine());
            //sumDigits(number);
            CreateArray();
        }
    }
}
