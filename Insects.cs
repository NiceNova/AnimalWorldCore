using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    interface Insects : IAnimal
    {

    }

    class YellowShel : Insects, ILandHabitat
    {
        string IAnimal.Name() => "Желтопанцерник ";
        string IAnimal.NameSupplement() => "Желтопанцерника";
        public string AttackManner() => " плюнул черной жижей ";

    }

}
