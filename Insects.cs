using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    class Insects : Animal/*, ILandHabitat*/
    {

    }

    class YellowShel : Insects
    {
        public YellowShel()
        {
            Name = "Желтопанцерник ";
            NameSupplement = "Желтопанцерника";
            AttackManner = " плюнул черной жижей ";
            Land = true;
        }

        public YellowShel(string name, string nameSupplement, string attackManner)
        {
            Name = name;
            NameSupplement = nameSupplement;
            AttackManner = attackManner;
            Land = true;
        }
    }
}
