using System;
using System.Threading;
using System.Threading.Tasks;

namespace Opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperaturGenerator tempGen = new TemperaturGenerator();

            Thread t1 = new Thread(tempGen.randomTemp);
            t1.Name = "Temp Generator";
            t1.Priority = ThreadPriority.Highest;
            t1.Start();

            while (t1.IsAlive)
            {
                Task.Delay(10000).Wait();
            }

            Console.WriteLine("Alarm-tråd termineret!");
        }



    }
}
