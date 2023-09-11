using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture1 = new Voiture("Clio", "Renault", "Vert");
            Console.WriteLine("La {0} {1} est de couleur {2}", 
                voiture1.Marque,
                voiture1.Modele,
                voiture1.Couleur
            );

            voiture1.Couleur = "Bleu";
            Console.WriteLine("La {0} {1} est de couleur {2}",
                voiture1.Marque,
                voiture1.Modele,
                voiture1.Couleur
            );

            voiture1.Roule();
        }
    }
}
