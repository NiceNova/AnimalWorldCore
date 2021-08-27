using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    class Reptiles : Animal/*, ILandHabitat*/
    {

    }
    class DesertRedBally : Reptiles
    {

        public DesertRedBally()
        {
            Name = "Пустынный краснопуз ";
            NameSupplement = "Пустынного краснопуза";
            AttackManner = " Швырнул хвостом ";
            Land = true;
        }

        public DesertRedBally(string name, string nameSupplement, string attackManner)
        {
            Name = name;
            NameSupplement = nameSupplement;
            AttackManner = attackManner;
            Land = true;
        }
    }
}
