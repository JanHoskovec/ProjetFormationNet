using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDesRobots
{
    public class Elephant : Animal
    {
        public decimal LongueurTrompe = 200.5M; //in cm

        public override void Dormir()
        {
            Console.WriteLine("Je dors dans la savane et je suis gigantesque.");
        }

    }
}
