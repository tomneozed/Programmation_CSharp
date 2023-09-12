using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegueSimple
{
    public delegate void SimpleDelegue();
    internal class Program
    {
        static void Main(string[] args)
        {
            DebutFacture();
            FinFacture();
            SimpleDelegue Info = new SimpleDelegue(DebutFacture);
            Info();

            Info = FinFacture;
            Info();
        }

        public static void DebutFacture()
        {
            Console.WriteLine("Début de facturation");
        }

        public static void FinFacture()
        {
            Console.WriteLine("Fin de facturation");
        }

    }
}
