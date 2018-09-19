using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDesRobots
{
    class Program
    {

        static void Main(string[] args)
        {
            //Animal animalCree = new Animal();
            //animalCree.NbMembres = 4;
            //animalCree.Espece = TypeAnimal.Elephant;
            //animalCree.AUneBouche = true;
            //animalCree.Name = "Jumbo";
            //Console.WriteLine("Voici mon premier animal.");
            //PrintAnimal(animalCree);

            //Animal animalCree2 = new Animal();
            //animalCree.NbMembres = 2;
            //animalCree.Espece = TypeAnimal.Humain;
            //animalCree.AUneBouche = true;
            //animalCree2.Name = "Evan";
            //Console.WriteLine("Voici mon second animal.");
            //PrintAnimal(animalCree2);

            //animalCree.Manger("des patates");
            //animalCree2.Manger("du bambou");

            //animalCree.Dormir();
            //animalCree2.Dormir();

            //Console.ReadLine();

            #region avecHeritage

            Animal monPremierAnimal = new Animal();
            Elephant elephant = new Elephant();
            Humain humain = new Humain();
            monPremierAnimal.Dormir();
            elephant.Dormir();
            humain.Dormir();

            
            Console.ReadLine();
            #endregion

            #region listDemo
            List<Animal> list = new List<Animal>();

            list.Add(new Humain());
            list.Add(new Elephant());
            list.Add(new Humain());
            list.Add(new Elephant());
            list.Add(new Humain());
            list.Add(new Elephant());

            ((Elephant)list[1]).LongueurTrompe = 230; // si l'élément n'est pas un élephant, une exception sera produite

            foreach (var animal in list)
            {
                animal.Dormir();
            }
            #endregion
            Console.ReadLine();
        }


        //private static void PrintAnimal(Animal a)
        //{
        //    Console.WriteLine($"Mon animal est un {a.Espece}. Il s'appelle {a.Name}. A-t-il une bouche ? " + (a.AUneBouche ? "Oui, il a aussi" : "Non, par contre il a") +
        //        $" {a.NbMembres} membre{(a.NbMembres > 1 ? "s" : "")}.");
        //}
    }
}
