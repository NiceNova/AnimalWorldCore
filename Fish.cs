using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    interface IFish : IAnimal
    {

    }

    class SpikeSwordBearer : IFish, IAquaticHabitat
    {
        string IAnimal.Name() => "Игольчатый меченеосец";
        string IAnimal.NameSupplement() => "Игольчатого меченеосца";
        public string AttackManner() => " пульнул шипом ";

    }

}
