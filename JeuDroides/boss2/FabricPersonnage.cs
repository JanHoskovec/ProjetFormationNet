using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss2
{
    public static class FabricPersonnage
    {
        public static Personnage  CreateOne(int index)
        {
            Personnage finalPersonnage = null;
            if ((TypeEspece)(index) == TypeEspece.Humain)
                finalPersonnage = new Humain();
            else if ((TypeEspece)(index) == TypeEspece.Wookie)
                finalPersonnage = new Wookie();
            else if ((TypeEspece)(index) == TypeEspece.Yoda)
                finalPersonnage = new Yoda();
            return finalPersonnage;

        }
    }
}
