using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPrograming
{
    public class Program
    {
        public void M1()
        {
            Thread t1 = Thread.CurrentThread;// to read the thread name
            Console.WriteLine(t1.Name);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }

        }
        public void M2()
        {
            Thread t1 = Thread.CurrentThread;// to read the thread name

            for (int i=0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            Thread t1=new Thread(new ThreadStart(p.M1));
            Thread t2 = new Thread(new ThreadStart(p.M2));
            t1.Start();
            t2.Start();
            t1.Name = "First Thread";
            t1.Name = "Second Number";
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

        }
    }
}
