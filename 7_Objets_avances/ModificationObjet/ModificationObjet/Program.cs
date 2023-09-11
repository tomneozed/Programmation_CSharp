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

        }
    }
}
