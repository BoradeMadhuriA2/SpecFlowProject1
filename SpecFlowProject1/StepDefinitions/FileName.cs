using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example to return multiple values from a function in c#
namespace SpecFlowProject1.StepDefinitions
{
    class Program
    {
        static int ReturnMultipleValuesUsingRef(int firstNumber, ref int secondNumber)
        {
            secondNumber = 20;
            return firstNumber;
        }
        static void Main()
        {
            int a = 10;
            int refValue = 0;
            var res = ReturnMultipleValuesUsingRef(a, ref refValue);
            System.Console.WriteLine($" Ref Value {refValue}");
            System.Console.WriteLine($" Function Return Value {res}");
            Console.ReadLine();
        }
    }


}
