using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    class Fish : Animal/*, IAquaticHabitat*/
    {

    }

    class SpikeSwordBearer : Fish
    {
        public SpikeSwordBearer()
        {
            Name = "Игольчатый меченеосец";
            NameSupplement = "Игольчатого меченеосца";
            AttackManner = " пульнул шипом ";
            Aqua = true;
        }

        public SpikeSwordBearer(string name, string nameSupplement, string attackManner)
        {
            Name = name;
            NameSupplement = nameSupplement;
            AttackManner = attackManner;
            Aqua = true;

        }

    }
    class GillsSnout : Fish
    {
        public new string AttackManner = " облизал усами ";
        public GillsSnout()
        {
            Name = "Жабрырыл";
            NameSupplement = "Жабрырыла";
            AttackManner = " облизал усами ";
            Aqua = true;

        }

        public GillsSnout(string name, string nameSupplement, string attackManner)
        {
            Name = name;
            NameSupplement = nameSupplement;
            AttackManner = attackManner;
            Aqua = true;

        }

    }
    class TailSnout : Fish
    {
        public TailSnout()
        {
            Name = "Хвостоморд";
            NameSupplement = "Хвостоморда";
            AttackManner = " измазал рыбьим жиром ";
            Aqua = true;

        }

        public TailSnout(string name, string nameSupplement, string attackManner)
        {
            Name = name;
            NameSupplement = nameSupplement;
            AttackManner = attackManner;
            Aqua = true;

        }
    }
}
