using System;
using System.Collections.Generic;
using System.IO;
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
            /*
                        AfficheMessage messager = new AfficheMessage(Info);
                        Processus(messager);
            */
            // --------------------------------------------------------------
            /*
                        SimpleDelegue Info = new SimpleDelegue(DebutFacture);
                        Info += FinFacture;
                        Info();
            */
            // --------------------------------------------------------------

            FichierDeLog FichierSortie = new FichierDeLog("C:\\FichierLogs.txt");
            AfficheMessage mInfo = new AfficheMessage(Info);

            mInfo += FichierSortie.Info;
            Processus(mInfo);

            FichierSortie.Ferme();
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

        public class FichierDeLog
        {
            FileStream fs;
            StreamWriter sw;

            public FichierDeLog(string fichier)
            {
                fs = new FileStream(fichier, FileMode.Create);
                sw = new StreamWriter(fs);
            }

            public void Info(string s)
            {
                sw.WriteLine(s);
            }

            public void Ferme()
            {
                sw.Close();
                fs.Close();
            }
        }
    }
}
