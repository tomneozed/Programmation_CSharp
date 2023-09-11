using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Voiture
    {
        public string Modele {  get; set; }
        public string Marque {  get; set; }
        public string Couleur {  get; set; }

        public Voiture() { }
        public Voiture(string modele, string marque, string couleur) {
            this.Modele = modele;
            this.Marque = marque;
            this.Couleur = couleur;
        }

        public void Roule() {
            Console.WriteLine("La voiture roule !");
        }

    }
}
