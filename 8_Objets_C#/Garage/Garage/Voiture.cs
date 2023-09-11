using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Voiture : Vehicule
    {
        public string modele;

        public Voiture(string modele, string marque, string couleur) {
            this.modele = modele;
            this.Marque = marque;
            this.Couleur = couleur;
        }

        public string Modele
        {
            get
            {
                return modele;
            }

            set
            {
                this.modele = value;
            }
        }

        public void Roule() {
            Console.WriteLine("La voiture roule !");
        }

    }
}
