using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDesRobots
{
    public class Humain : Animal
    {
        public override void Dormir()
        {
            Console.WriteLine("Je dors alongé dans mon lit.");
        }
    }
}
