using System;
using System.Threading;

namespace Øvelse_0
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadProgram threadProgram = new ThreadProgram();

            Thread t1 = new Thread(threadProgram.WorkThreadFunction);
            t1.Name = "Thread 1";
            t1.Start();

            Thread t2 = new Thread(threadProgram.WorkThreadFunction);
            t2.Name = "Thread 2";
            t2.Start();

            Console.ReadLine();

        }
    }

    class ThreadProgram
    {
        public void WorkThreadFunction()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}] Simple Thread, Thread Name: {Thread.CurrentThread.Name}");
            }
        }

    }
}
