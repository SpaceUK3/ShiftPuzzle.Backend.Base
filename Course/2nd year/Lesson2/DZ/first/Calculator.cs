using System;

namespace sfg
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int summ = num1 + num2;
            System.Console.WriteLine(summ);
        }
    }
}