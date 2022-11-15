using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Event
{
    public class Delegates
    {
        public static void Addition(int a,int b)
        {
            Console.WriteLine("Addition is : "+(a+b));
        }
        public static void Substarction(int a, int b)
        {
            Console.WriteLine("Substraction is : " + (a - b));
        }
        public static void Multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication is : " + (a * b));
        }
    }
}
