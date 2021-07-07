using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    interface IReptiles : IAnimal
    {

    }
    class DesertRedBally : IReptiles, ILandHabitat
    {
        string IAnimal.Name() => "Пустынный краснопуз ";
        string IAnimal.NameSupplement() => "Пустынного краснопуза";
        public string AttackManner() => " Швырнул хвостом ";



    }
}
