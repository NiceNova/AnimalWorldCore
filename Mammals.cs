using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    class Mammals : Animal/*, ILandHabitat*/
    {
       
    }

    class NeedleBelly : Mammals 
    {
        public NeedleBelly()
        {
            Name = "Иглобрюх";
            NameSupplement = "Иглобрюха";
            AttackManner = " сделал бдыщ ";
            Land = true;
        }

        public NeedleBelly(string name, string nameSupplement, string attackManner)
        {
            Name = name;
            NameSupplement = nameSupplement;
            AttackManner = attackManner;
            Land = true;
        }
    }
}
