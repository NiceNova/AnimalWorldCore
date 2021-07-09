using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    interface IFish : IAquaticHabitat
    {

    }

    class SpikeSwordBearer : IFish
    {
        string IAnimal.Name() => "Игольчатый меченеосец";
        string IAnimal.NameSupplement() => "Игольчатого меченеосца";
        public string AttackManner() => " пульнул шипом ";

    }

}
