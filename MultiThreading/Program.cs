using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread T1 = new Thread(MultiThreading.Method1);
            T1.Name = "Thread1";
            Thread T2 = new Thread(MultiThreading.Method2);
            T2.Name = "Thread2";
            Thread T3 = new Thread(MultiThreading.Method3);
            T3.Name = "Thread3";
            
            
            
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine( " Inside Main Thread for time - {0} ",i);
                if (i == 2)
                {
                    T1.Start();
                    T2.Start();
                    T3.Start();
                    Thread.Sleep(2000);
                }
                
                if (i == 5)
                {
                    try
                    {
                        T1.Suspend();
                        T2.Suspend();
                        T3.Suspend();
                    }
                    catch (ThreadStateException ex)
                    {
                        Console.WriteLine( "Exception :" + ex.Message );
                    } 
                    
                }
                if (i == 6)
                {
                    try
                    {
                        T1.Resume();
                        T2.Resume();
                        T3.Resume();
                    }
                    catch (ThreadStateException ex)
                    {
                        Console.WriteLine("Exception :" + ex.Message);
                    }

                }
                if (i == 8)
                {
                    T1.Abort();
                    T2.Abort();
                    T3.Abort();
                }

            }

            Console.ReadLine();


        }
        
    }
}
