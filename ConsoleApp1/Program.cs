using System;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.Arm;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("1 For Addition. 2 For Multipication. 3 For Subtraction. 4 for division");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 1st Number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter then 2nd Number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    calculator Calculator = new calculator();
                    calculator.AddTwoNumbers(firstNumber, secondNumber);
                    break;
                case 2:
                    calculator Calculator1 = new calculator();
                    calculator.MulTwoNumbers(firstNumber, secondNumber);
                    break;
                case 3:
                    calculator Calculator2 = new calculator();
                    calculator.SubTwoNumbers(firstNumber, secondNumber);
                    break;
                case 4:
                    calculator Calculator3 = new calculator();
                    calculator.DivTwoNumbers(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            //calculator calculator= new calculator();


            //calculator.AddTwoNumbers(firstNumber, secondNumber);
            Console.ReadLine();

        }
    }
}
