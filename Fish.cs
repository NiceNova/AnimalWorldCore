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
    class GillsSnout : IFish
    {
        string IAnimal.Name() => "Жабрырыл";
        string IAnimal.NameSupplement() => "Жабрырыла";
        public string AttackManner() => " облизал усами ";

    }
    class TailSnout : IFish
    {
        string IAnimal.Name() => "Хвостоморд";
        string IAnimal.NameSupplement() => "Хвостоморда";
        public string AttackManner() => " измазал рыбьим жиром ";

    }


}
