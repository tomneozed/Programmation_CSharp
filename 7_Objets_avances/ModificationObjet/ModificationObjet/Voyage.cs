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

        public Voyage(decimal montant) : base("Voyage", montant) { }

        public Voyage(decimal montant, uint quantite) : base("Voyage ", montant, quantite){ }
    }
}
