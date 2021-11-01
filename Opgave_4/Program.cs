using System;
using System.ComponentModel.Design;
using System.Threading;
using System.Threading.Tasks;

namespace Opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(reader);
            t1.Name = "Input";
            t1.Start();


            Thread t2 = new Thread(printer);
            t2.Name = "Output";
            t2.Start();

        }

        private static char ch = '*';
        static void printer()
        {
            while (true)
            {
                Console.Write(ch);
                Task.Delay(100).Wait();
            }
        }


        static void reader()
        {
            while (true)
            {
                char keyChar = Console.ReadKey(true).KeyChar;

                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    ch = keyChar;
                }
            }
        }
    }
}
