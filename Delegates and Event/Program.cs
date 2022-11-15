namespace Delegates_and_Event
{
    public class Program
    {
        public static event DelEventHandler Del;
        static void Main(string[] args)
        {

            EventHandling.ImplementEvent();
            
            //Del +=new DelEventHandler(Event.Ramchandra);
            //Del += new DelEventHandler(Event.Shrikant);
            //Del += new DelEventHandler(Event.Mahesh);
            //Del.Invoke();
        }
    }
}