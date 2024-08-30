using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regnelokke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppg 1 & 2
            Console.WriteLine("Vennligst oppgi tall, si \"0\" for å avslutte løkken");

            int input;
            List<int> tall = new List<int>();

            while (true)
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input != 0)
                    {
                        tall.Add(input);
                    } else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Vennligst oppgi et gyldig heltall");
                }
            }

            //Oppg 3
            foreach (int i in tall)
            {
                Console.WriteLine(i);
            }

            //Oppg 4
            int minSum = 0;

            foreach (int i in tall)
            {
                minSum += i;
            }

            Console.WriteLine(minSum);

            //Oppg 5
            int min = 0;
            int max = 0;

            foreach (int i in tall)
            {
                if (min != 0)
                {
                    if (i < min)
                    {
                        min = i;
                    }
                } else
                {
                    min = i;
                }
            }

            Console.WriteLine($"Det minste tallet er {min}");

            foreach (int i in tall)
            {
                if (max < i)
                {
                    max = i;
                }
            }

            Console.WriteLine($"Det største tallet er {max}");

            Console.ReadLine();
        }
    }
}
