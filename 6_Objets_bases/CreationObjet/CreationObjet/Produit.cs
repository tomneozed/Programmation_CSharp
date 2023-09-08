using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationObjet
{
    internal class Produit
    {
        public string nom; //nom du produit
        public uint quantite; // quantité superieure a 0
        decimal montant; // montant superieur a 0

        public void setMontant(decimal montant)
        {
            if (montant < 0)
            {
                Console.WriteLine("please enter a positive value");
            } else
            {
                this.montant = montant;
            }
        }

        public decimal getMontant()
        {
            return this.montant;
        }
    }
}
