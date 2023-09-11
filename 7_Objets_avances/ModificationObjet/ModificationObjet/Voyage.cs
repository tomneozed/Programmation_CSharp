using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificationObjet
{

    internal class Voyage : Produit
    {
        public decimal Pourcentage { get; set; }

        public Voyage() : base("Voyage") { }

        public Voyage(decimal montant) : base("Voyage", montant) { Pourcentage = 19.6M; }

        public Voyage(decimal montant, uint quantite, decimal pourcentage) : base("Voyage ", montant, quantite) { Pourcentage = pourcentage; }

        public override decimal CalculTTC()
        {
            return Montant * (1 + Pourcentage / 100) * Quantite;
        }
    }
}
