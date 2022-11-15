using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Event
{
    public delegate void DelEventHandler();
    public class Event
    {
        public static void Ramchandra()
        {
            Console.WriteLine("Ramchandra");
        }
        public static void Shrikant()
        {
            Console.WriteLine("Shrikant");
        }
        public static void Mahesh()
        {
            Console.WriteLine("Mahesh");
        }
    }
}
