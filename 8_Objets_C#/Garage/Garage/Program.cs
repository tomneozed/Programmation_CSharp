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
            /*
                        Voiture voiture1 = new Voiture("Clio", "Renault", "Verte");
                        Console.WriteLine("La voiture {0} {1} est de couleur {2}", 
                            voiture1.Marque,
                            voiture1.Modele,
                            voiture1.Couleur
                        );

                        voiture1.Couleur = "Bleue";
                        Console.WriteLine("La voiture {0} {1} est de couleur {2}",
                            voiture1.Marque,
                            voiture1.Modele,
                            voiture1.Couleur
                        );

                        voiture1.Roule();
            */
            // -----------------------------------------------------------
            /*
                        Voiture voiture2 = new Voiture();
                        Console.WriteLine("La voiture {0} {1} est de couleur {2}",
                           voiture2.Marque,
                           voiture2.Modele,
                           voiture2.Couleur
                       );
            */
            // -----------------------------------------------------------

            /*
            Voiture voiture3 = new Voiture("Clio", "Renault", "Verte");
            Console.WriteLine("La voiture {0} {1} est de couleur {2}",
                           voiture3.Marque,
                           voiture3.Modele,
                           voiture3.Couleur
                       );
            voiture3.Couleur = "Bleue";
            Console.WriteLine("La voiture {0} {1} est de couleur {2}",
                          voiture3.Marque,
                          voiture3.Modele,
                          voiture3.Couleur
                      );

            voiture3.Roule();

            Vehicule vehicule = new Vehicule();

            Console.WriteLine("Le vehicule {0} est de couleur {1}",
                          vehicule.Marque,
                          vehicule.Couleur
                      );

            vehicule.Roule();
*/
            // -----------------------------------------------------------

            Voiture voiture4 = new Voiture("Clio", "Renault", "Verte");
            Console.WriteLine("La voiture {0} {1} est de couleur {2}",
                           voiture4.Marque,
                           voiture4.Modele,
                           voiture4.Couleur
                       );
            voiture4.Couleur = "Bleue";
            Console.WriteLine("La voiture {0} {1} est de couleur {2}",
                          voiture4.Marque,
                          voiture4.Modele,
                          voiture4.Couleur
                      );

            voiture4.Roule();

            // -----------------------------------------------------------
        }
    }
}
