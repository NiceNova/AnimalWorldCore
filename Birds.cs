using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    class Birds : Animal/*, ILandHabitat*/
    {
    }
    class BeakTail : Birds
    {

        public BeakTail()
        {
            Name = "Клювохвост";
            NameSupplement = "Клювохвоста";
            AttackManner = " сделал кар ";
            Land = true;
        }

        public BeakTail(string name, string nameSupplement, string attackManner)
        {
            Name = name;
            NameSupplement = nameSupplement;
            AttackManner = attackManner;
            Land = true;
        }
    }
}
