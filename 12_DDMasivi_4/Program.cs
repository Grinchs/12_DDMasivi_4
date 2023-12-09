using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_DDMasivi_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] masivs = new int[10, 10];

            Random rand = new Random();
            for (int rinda = 0; rinda < 10; rinda++)
            {
                for (int kolonna = 0; kolonna < 10; kolonna++)
                {
                    masivs[rinda, kolonna] = rand.Next(1, 10);
                }
            }

            for (int rinda = 0; rinda < 10; rinda++)
            {
                for (int kolonna = 0; kolonna < 10; kolonna++)
                {
                    Console.Write($"{masivs[rinda, kolonna],4}");
                }
                Console.WriteLine();
            }

            // Samainīt vērtības virs galvenās diagonāles uz 0
            for (int rinda = 0; rinda < 10; rinda++)
            {
                for (int kolonna = rinda + 1; kolonna < 10; kolonna++)
                {
                    masivs[rinda, kolonna] = 0;
                }
            }

            Console.WriteLine("\nMasīvs pēc vērtību samainīšanas virs galvenās diagonāles:");
            for (int rinda = 0; rinda < 10; rinda++)
            {
                for (int kolonna = 0; kolonna < 10; kolonna++)
                {
                    Console.Write($"{masivs[rinda, kolonna],4}");
                }
                Console.WriteLine();
            }
        }
    }
}