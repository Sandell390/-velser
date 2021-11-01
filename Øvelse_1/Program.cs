using System;
using System.Threading;

namespace Øvelse_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(print);
            t1.Name = "T1";
            t1.Start("C#-trådning er nemt!");
            

            Thread t2 = new Thread(print);
            t2.Name = "T2";
            t2.Start("C#-trådning er nemt!");
            

            Thread t3 = new Thread(print);
            t3.Name = "T3";
            t3.Start("Også med flere tråde ...");
            
        }

        static void print(object arg)
        {
            string msg = arg as string;
            if (!string.IsNullOrEmpty(msg))
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(msg + "Thread: " + Thread.CurrentThread.Name);
                }
            }
        }
    }
}
