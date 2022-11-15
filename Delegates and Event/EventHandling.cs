using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Event
{
    public delegate void EventHandler(string name);
    public class EventHandling
    {
        public class Operation
        {
            public event EventHandler? events;
            public  void Action(string name)
            {
                if (events != null)
                {
                    events(name);
                    Console.WriteLine(name);
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
        }
        private static void CatchEvent(string name)
        {
            Console.WriteLine("Method Calling");
        }
        public static void ImplementEvent()
        {
            Operation operation= new Operation();
            operation.Action("Event Calling");

            Console.WriteLine();

            operation.events += new EventHandler(CatchEvent);
            operation.Action("Event Called");
        }
    }
}
