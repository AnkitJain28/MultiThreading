using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class MultiThreading
    {
        public static void Method1()
        {
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine( " Inside Thread 1 for time - {0} ",i);
                if (i == 2) Thread.Sleep(2000);
                                
            }
            
        }
        public static void Method2()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine( " Inside Thread 2 for time - {0} ",i );
                if (i == 3) Thread.Sleep(2000);

            }
        }
        public static void Method3()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine( " Inside Thread 3 for time - {0} ",i );
                if (i == 4) Thread.Sleep(2000);

            }
        }
    }
}
