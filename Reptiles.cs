using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    interface IReptiles : ILandHabitat
    {

    }
    class DesertRedBally : IReptiles
    {
        string IAnimal.Name() => "Пустынный краснопуз ";
        string IAnimal.NameSupplement() => "Пустынного краснопуза";
        public string AttackManner() => " Швырнул хвостом ";



    }
}
