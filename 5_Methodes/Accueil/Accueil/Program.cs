using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accueil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;
            DayOfWeek day = DateTime.Now.DayOfWeek;
            string username = Environment.UserName;

            if (day == DayOfWeek.Monday ||
                day == DayOfWeek.Tuesday ||
                day == DayOfWeek.Wednesday ||
                day == DayOfWeek.Thursday ||
                day == DayOfWeek.Friday )
            {
                if (hour > 7 && hour <= 12)
                {
                    Console.WriteLine("Bonjour " + username);
                }
                else if (hour > 12 && hour <= 18)
                {
                    Console.WriteLine("Bonne apres midi " + username);
                }
                else if (hour > 18 && hour <= 22)
                {
                    Console.WriteLine("Bonsoir " + username);
                }
                else if (hour > 22 || hour <= 7)
                {
                    Console.WriteLine("Bonne nuit " + username);
                }
            } else
            {
                Console.WriteLine("Bon Week-End " + username);
            }

            





            /*switch (hour) {
                case (hour > 7 && hour < 18):
                    Console.WriteLine("bonjour");
            }*/
        }
    }
}
