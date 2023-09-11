using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificationObjet
{
    internal interface IProduit
    {
        decimal CalculTTC();

        string Nom { get; set; }
    }
}
