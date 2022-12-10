using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class calculator
    {
        public static void AddTwoNumbers(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine("Sum Of Two Numbers {0} ", result);
           // return result;
        }

        public static void MulTwoNumbers(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            Console.WriteLine("multipication of two Number{0}", result);
          //  return result;
        }



        public static void SubTwoNumbers(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            Console.WriteLine("Sub Of Two Numbers {0} ", result);
         //   return result;
        }
        public static void DivTwoNumbers(int firstNumber, int secondNumber)
        {
            float result = (float)firstNumber / (float)secondNumber;
            Console.WriteLine("Div Of Two Numbers" + result);
            //   return result;
        }
    }

}
