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
        private decimal montant; // montant superieur a 0

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

        public Produit()
        {

        }

        public Produit(string nom) : this(nom, 0M)
        {
            
        }

        public Produit(string nom, decimal montant): this(nom, montant, 0)
        {

        }

        public Produit(string nom, decimal montant, uint quantite)
        {
            this.nom = nom;
            this.montant = montant;
            this.quantite = quantite;
        }

        public decimal CalculTTC()
        {
            return montant * 1.196M * quantite;
        }

        public decimal CalculPromotion(int pourcentageReduction)
        {
            return CalculTTC() * (1 - pourcentageReduction / 100M);
        }

        public decimal CalculPromotion(string fournisseur, decimal montant)
        {
            return CalculPromotion(montant);
        }

        public decimal CalculPromotion(decimal montant)
        {
            return CalculTTC() - montant;
        }
    }
}
