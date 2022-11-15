using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Event
{
    public class DelegateArray
    {
        public delegate void operation(int x,int y);

        public static void DelegateImplement()
        {
            operation[] obj =
            {
                new operation(Delegates.Addition),
                new operation(Delegates.Substarction),
                new operation(Delegates.Multiplication),
            };
            for(int i=0;i<obj.Length;i++)
            {
                obj[i](10,20);
                obj[i](20,10);
                obj[i](30,20);
                Console.WriteLine();
            }
        }
    }
}
