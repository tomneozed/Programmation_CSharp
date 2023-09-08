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
            }
            else
            {
                Console.WriteLine("Produits différents");
            }

            // --------------------------------------------

            produit.quantite = 10;
            produit.setMontant(15);

            Console.WriteLine("Montant TTC produit 1 : " + produit.CalculTTC());

            produit2.quantite = 5;
            produit2.setMontant(10);

            Console.WriteLine("Montant TTC produit 2 : " + produit2.CalculTTC());

            // --------------------------------------------

            Console.WriteLine("prix {0} avec 5% de réduction {1}", produit.CalculTTC(), produit.CalculPromotion(5));

            // --------------------------------------------

            Produit produit3 = new Produit("Produit3");
            Produit produit4 = new Produit("Produit4", 10);
            Produit produit5 = new Produit("Produit5", 10, 15);

            Console.WriteLine(produit3.nom);
            Console.WriteLine(produit3.getMontant());
            Console.WriteLine(produit3.quantite);

            Console.WriteLine(produit4.nom);
            Console.WriteLine(produit4.getMontant());
            Console.WriteLine(produit4.quantite);

            Console.WriteLine(produit5.nom);
            Console.WriteLine(produit5.getMontant());
            Console.WriteLine(produit5.quantite);

            // --------------------------------------------

            Voyage voyage1 = new Voyage();
            Voyage voyage2 = new Voyage("Voyage 2");
            Voyage voyage3 = new Voyage("Voyage 3", 5);

            Console.WriteLine(voyage1.nom);
            Console.WriteLine(voyage1.getMontant());
            Console.WriteLine(voyage1.quantite);

            Console.WriteLine(voyage2.nom);
            Console.WriteLine(voyage2.getMontant());
            Console.WriteLine(voyage2.quantite);

            Console.WriteLine(voyage3.nom);
            Console.WriteLine(voyage3.getMontant());
            Console.WriteLine(voyage3.quantite);

        }
    }
}
