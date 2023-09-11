using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    abstract class Vehicule : IVehicule
    {
        private string marque;
        private string couleur;

        public Vehicule() { }

        public Vehicule(string marque, string couleur)
        {
            this.marque = marque;
            this.couleur = couleur;
        }

        public string Marque
        {
            get
            {
                return marque;
            }

            set
            {
                this.marque = value;
            }
        }

        public string Couleur
        {
            get
            {
                return couleur;
            }

            set
            {
                this.couleur = value;
            }
        }

        public abstract void Roule();

    }
}
