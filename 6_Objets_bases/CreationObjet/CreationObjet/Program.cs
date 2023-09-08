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
        }
    }
}
