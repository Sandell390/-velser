using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Opgave_3
{
    public class TemperaturGenerator
    {
        public int _temperatur { get; set; }


        public TemperaturGenerator()
        {
            _temperatur = 0;
        }

        public void randomTemp()
        {
            bool power = true;
            int fails = 0;
            Random random = new Random();

            while (power)
            {
                _temperatur = random.Next(-20, 120);

                Console.Write($"Temperatur: {_temperatur} ");

                if (_temperatur > 100 || _temperatur < 0)
                {
                    Console.Write("| Alarm!");
                    fails++;
                }

                if (fails >= 3)
                {
                    power = false;
                }

                Console.WriteLine();

                Task.Delay(2000).Wait();
            }
        }

    }
}
