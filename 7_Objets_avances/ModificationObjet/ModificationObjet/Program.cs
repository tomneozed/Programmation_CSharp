using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificationObjet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voyage voyage = new Voyage(3500.00M);
            voyage.Quantite = 1;
            Console.WriteLine("Le produit voyage coute {0} HT. Montant TTC pour {1} : {2}", 
                voyage.getMontant(), 
                voyage.Quantite, 
                voyage.CalculTTC()
            );

            voyage.Pourcentage = 20.6M;
            Console.WriteLine("Le produit Voyage coute {0:f} HT. Montant TTC (TVA {3}%) pour {1} : {2:f}", 
                voyage.Montant, 
                voyage.Quantite, 
                voyage.CalculTTC(), 
                voyage.Pourcentage);

            // ---------------------------------------------------------------------------------------------
            /*
                        Produit produit = new Produit("Voyage");
                        produit.Quantite = 1;
                        produit.Montant = 1000;
                        Console.WriteLine("Le produit Voyage coute {0:c} HT. Montant TTC pour {1} : {2:c}", 
                            produit.Montant, 
                            produit.Quantite, 
                            produit.CalculTTC());

                        Voyage voyage2 = new Voyage(350.00M); 
                        Console.WriteLine("Le produit Voyage coute {0} HT. pour {1} : {2} (TVA {3}%)", 
                            voyage2.Montant, 
                            voyage2.Quantite, 
                            voyage2.CalculTTC(), 
                            voyage2.Pourcentage);
            */
            // ---------------------------------------------------------------------------------------------
            Voyage voyage3 = new Voyage();
            voyage3.Quantite = 1;
            voyage3.Montant = 1000;
            Console.WriteLine("Le produit Voyage coute {0:c} HT. Montant TTC pour {1} : {2:c}",
                voyage3.Montant,
                voyage3.Quantite,
                voyage3.CalculTTC());

            Voyage voyage4 = new Voyage(350.00M);
            Console.WriteLine("Le produit Voyage coute {0} HT. pour {1} : {2} (TVA {3}%)",
                voyage4.Montant,
                voyage4.Quantite,
                voyage4.CalculTTC(),
                voyage4.Pourcentage);

        }
    }
}
