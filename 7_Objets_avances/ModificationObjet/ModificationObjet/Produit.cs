using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificationObjet
{
    internal class Produit
    {
        private string Nom; //nom du produit
        public uint Quantite; // quantité superieure a 0
        public decimal Montant; // montant superieur a 0

        public void setMontant(decimal montant)
        {
            if (montant < 0)
            {
                Console.WriteLine("please enter a positive value");
            }
            else
            {
                this.Montant = montant;
            }
        }

        public decimal getMontant()
        {
            return this.Montant;
        }

        public Produit()
        {
            this.Nom = "nom_produit";
            this.Montant = 0;
            this.Quantite = 0;
        }

        public Produit(string nom) : this(nom, 0M, 0)
        {

        }

        public Produit(string nom, decimal montant) : this(nom)
        {
            this.Montant = montant;
        }

        public Produit(string nom, decimal montant, uint quantite)
        {
            this.Nom = nom;
            this.Montant = montant;
            this.Quantite = quantite;
        }

        public decimal CalculTTC()
        {
            return Montant * 1.196M * Quantite;
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
