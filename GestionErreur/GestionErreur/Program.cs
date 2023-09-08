using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionErreur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int reponse = 0;
            do
            {
                try
                {
                    Console.Write("Veuillez entrer une valeur entre 1 et 3 : ");
                    reponse = int.Parse(Console.ReadLine());

                }catch (FormatException ex)
                {
                    Console.WriteLine("Veuillez rentrer un entier compris entre 1 et 3");
                }

            } while (!reponse.Equals(1) && !reponse.Equals(2) && !reponse.Equals(3));
            int laValeur = 0;

            switch (reponse)
            {
                case 1:
                    goto default;
                    break;
                case 2:
                    laValeur += 25;
                    break;
                case 3:
                    laValeur += 30;
                    goto default;
                default:
                    laValeur += 10;
                    break;
            }
            Console.WriteLine("La valeur est : " + laValeur);
        }
    }
}
