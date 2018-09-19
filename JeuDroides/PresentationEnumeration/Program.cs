using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationEnumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeEspece monEspece = TypeEspece.Wookie;
            monEspece = TypeEspece.Yoda;
            int monEspeceValeur = (int) monEspece;
            decimal monDecimal = monEspeceValeur;
            monEspeceValeur = (int) monDecimal;
        }
    }
}
