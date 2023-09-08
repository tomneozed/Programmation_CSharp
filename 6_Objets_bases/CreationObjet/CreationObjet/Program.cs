using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationObjet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produit produit = new Produit();
            produit.nom = "Voyage";
            produit.quantite = 10;
            produit.setMontant(1);

            Console.WriteLine(produit.nom);
            Console.WriteLine(produit.quantite);
            Console.WriteLine(produit.getMontant());

            Produit produit2 = new Produit();
            produit2.nom = "Voyage";
            // produit2 = produit;
            if (produit == produit2)
            {
                Console.WriteLine("produits identiques");
            } else
            {
                Console.WriteLine("Produits différents");
            }

            // --------------------------------------------

            produit.quantite = 10;
            produit.setMontant(15);

            Console.WriteLine("Montant TTC produit 1 : " + produit.calculTTC());

            produit2.quantite = 5;
            produit2.setMontant(10);

            Console.WriteLine("Montant TTC produit 2 : " + produit2.calculTTC());
        }
    }
}
