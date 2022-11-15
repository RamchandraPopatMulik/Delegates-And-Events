using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Event
{
    public class DelegateArray
    {
        public delegate void operation( int x,int y );

        public static void DelegateImplement()
        {
            operation obj = Delegates.Addition;
            obj+=Delegates.Substarction;
            obj += Delegates.Multiplication;

            obj(10,30);
            Console.WriteLine();
            obj(20,10);
            Console.WriteLine();
            obj(30,20);
            Console.WriteLine();
        }
    }
}
