using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class calculator
    {
       public int AddTwoNumbers(int firstNumber,int secondNumber)
        {   
            int result=firstNumber + secondNumber;
            Console.WriteLine("Sum Of Two Numbers {0} ",result);
            int result2 = firstNumber - secondNumber;
            Console.WriteLine("diff of two Number{0}" ,result2);
            int result3 = firstNumber * secondNumber;
            Console.WriteLine("multipication of two Number{0}", result3);
            return result;
        }
   }
}
