using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (i = 0; i < 10; i++)
            {

            }
            Console.WriteLine(i);

            // -------------------------------------

            int j;
            boucle(20, out j);
            Console.WriteLine(j);

            // -------------------------------------

            MaBoucle maBoucle = new MaBoucle();
            maBoucle.boucle(20);
            Console.WriteLine(maBoucle.i);
        }
        static void boucle(int valeur, out int i)
        {
            for (i = 0; i < valeur; i++)
            {

            }
        }
    }
}
