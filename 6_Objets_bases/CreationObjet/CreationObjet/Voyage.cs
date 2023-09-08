using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationObjet
{
    internal class Voyage : Produit
    {
        public Voyage()
        {
            this.nom = "Voyage sans nom";
        }

        public Voyage(string nom) : this(nom, 0M)
        {

        }

        public Voyage(string nom, decimal montant)
        {
            this.nom = nom;
            this.setMontant(montant);
        }
    }
}
