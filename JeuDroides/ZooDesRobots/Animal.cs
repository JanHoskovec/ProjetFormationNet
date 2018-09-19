using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDesRobots
{
    public class Animal
    {
       
        public int NbMembres = 4;
        public bool AUneBouche = true;
        public string Name;

        public void Manger(string maNourriture)
        {
            Console.WriteLine("Je mange : " + maNourriture);
        }

        public virtual void Dormir()
        {
            Console.WriteLine("Je dors comme un animal et je vous emm....");
        }

    }
}
