using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametreTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tableau = { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };

            string[,] tableau2 = {
                { "lundi", "monday" },
                { "mardi", "tuesday" },
                { "mercredi", "wednesday" },
                { "jeudi", "thursday" },
                { "vendredi", "friday" },
                { "samedi", "saturday" },
                { "dimanche", "sunday" }
            };

            foreach (string item in tableau)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < tableau2.GetLength(0); i++)
            {
                for (int j = 0; j < tableau2.GetLength(1); j++)
                {
                    Console.Write(tableau2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
