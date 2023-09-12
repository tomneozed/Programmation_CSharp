using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegueSimple
{
    public delegate void SimpleDelegue();

    public delegate void AfficheMessage(string message);

    internal class Program
    {
        static void Main(string[] args)
        {
/*
            DebutFacture();
            FinFacture();
            SimpleDelegue Info = new SimpleDelegue(DebutFacture);
            Info();

            Info = FinFacture;
            Info();
*/
            // --------------------------------------------------------------

            AfficheMessage messager = new AfficheMessage(Info);
            Processus(messager);

        }

        public static void DebutFacture()
        {
            Console.WriteLine("Début de facturation");
        }

        public static void FinFacture()
        {
            Console.WriteLine("Fin de facturation");
        }

        static void Info(string message)
        {
            Console.WriteLine(message);
        }

        public static void Processus(AfficheMessage Affichage) {
            if (Affichage != null)
            {
                Affichage("Début de la facturation");
            }
            if (Affichage != null)
            {
                Affichage("Facture Terminée");
            }
        }

    }
}
