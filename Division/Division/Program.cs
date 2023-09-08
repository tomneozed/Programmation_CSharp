using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal divise = 0;
            decimal diviseur = 0;
            decimal resultat = 0;

            do
            {
                try
                {
                    Console.Write("Veuillez entrer une valeur à diviser : ");
                    divise = decimal.Parse(Console.ReadLine());
                    Console.Write("Veuillez entrer une autre valeur par laquelle diviser : ");
                    diviseur = decimal.Parse(Console.ReadLine());

                    try
                    {
                        resultat = divise/diviseur;
                       
                    }catch(DivideByZeroException ex)
                    {
                        Console.WriteLine("x/0 = infini et ça rentre pas dans un int");
                    }

                }
                catch (FormatException ex)
                {
                    // Gestion des non-entiers
                    Console.WriteLine("Veuillez rentrer des entiers");
                }
                Console.WriteLine("Résultat : " + resultat);

            } while (resultat == 0);
        }
    }
}
