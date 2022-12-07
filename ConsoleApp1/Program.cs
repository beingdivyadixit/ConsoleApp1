using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            calculator calculator= new calculator();
            Console.WriteLine("Enter the 1st Number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter then 2nd Number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            calculator.AddTwoNumbers(firstNumber, secondNumber);
            Console.ReadLine();

        }
    }
}
