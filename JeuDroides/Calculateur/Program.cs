using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculateur
{
    class Program
    {

        static void AfficheSomme(int a, int b)
        {
            int c = a + b;
            Console.WriteLine($"a = {a}, b = {b}, a + b = {c} ou {a} + {b} = {c}");
        }

        static void AfficheMultiple(int a, int b)
        {
            int c = a * b;
            Console.WriteLine($"a = {a}, b = {b}, a * b = {c} ou {a} * {b} = {c}");
        }

        static void Main(string[] args) 
        {
            Console.WriteLine("dans un premier temps, nous allons additionner a + b : ");

            AfficheSomme(5, 3); 
            AfficheSomme(18, 8);

            Console.WriteLine("et maintenant, on va passer à la multiplication a * b : ");

            AfficheMultiple(3, 8);
            AfficheMultiple(18, 27);

            Console.ReadLine();        
        
        }
    }
}
