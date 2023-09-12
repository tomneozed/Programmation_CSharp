using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegueSimple
{
    public delegate void SimpleDelegue();

    public delegate void AfficheMessage(string message);

    public delegate void ExempleCallback();

    public delegate void ChangementEtat();

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
            /*
                        FichierDeLog FichierSortie = new FichierDeLog("C:\\FichierLogs.txt");
                        AfficheMessage mInfo = new AfficheMessage(Info);

                        mInfo += FichierSortie.Info;
                        Processus(mInfo);

                        FichierSortie.Ferme();
            */
            // --------------------------------------------------------------
            /*
                        ThreadStart tacheDelegue = new ThreadStart(UneTache);
                        Thread tache = new Thread(tacheDelegue);
                        tache.Start();

                        ThreadAvecParametre thread = new ThreadAvecParametre(5);

                        thread.TacheParallele();
            */
            /*
                        ThreadAvecParametre ta = new ThreadAvecParametre(20, new ExempleCallback(MethodeCallBack));
                        Thread tache = new Thread(new ThreadStart(ta.TacheParallele));
                        tache.Start();
                        for(int i = 30; i > 1; i--)
                        {
                            Thread.Sleep(1000);
                            Console.Write(".");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Toutes les factures sont terminées");
            */
            // --------------------------------------------------------------
            /*
                        MonCompteur compteur = new MonCompteur(10);
                        compteur.TravailTermine += new ChangementEtat(Delegue_TravailTermine);

                        for (int i = 0; i < 20; i++)
                        {
                            compteur.Incrementation();
                        }
                        Console.WriteLine(compteur.Increment);
            */
            // --------------------------------------------------------------

            ThreadAvecParametre ta = new ThreadAvecParametre(20);
            ta.callback += new ExempleCallback(MethodeCallBack);

            Thread tache = new Thread(new ThreadStart(ta.TacheParallele));
            tache.Start();

            for (int i = 30; i > 1; i--)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine();
            Console.WriteLine("Toutes les factures sont terminées");

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

        public static void Processus(AfficheMessage Affichage)
        {
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

        static void UneTache()
        {
            Console.WriteLine("Facturation en cours");
        }

        class ThreadAvecParametre
        {
            int secondes;
            public event ExempleCallback callback;
            public ThreadAvecParametre(int s)
            {
                this.secondes = s;
            }

            public void TacheParallele()
            {
                Console.WriteLine("Debut de la Facturation");
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(this.secondes / 5 * 1000);
                    Console.WriteLine();
                    Console.WriteLine("Facturation en cours");
                }
                if (this.callback != null)
                {
                    callback();
                }
            }
        }

        public static void MethodeCallBack()
        {
            Console.WriteLine("Facture terminée");
        }

        public class MonCompteur
        {
            private int compteur;

            public MonCompteur(int c)
            {
                this.compteur = c;
            }

            public event ChangementEtat TravailTermine;
            private int increment;

            public int Increment
            {
                get { return increment; }
                set 
                { 
                    increment = value;
                    if(increment == compteur)
                    {
                        if (TravailTermine != null)
                        {
                            TravailTermine();
                        }
                    }
                }
            }

            public void Incrementation()
            {
                Increment++;
            }
        }

        static void Delegue_TravailTermine()
        {
            Console.WriteLine("Le compteur a atteint la valeur cible");
        }
    }
}