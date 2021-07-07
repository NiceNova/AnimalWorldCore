using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    interface IMammals : IAnimal
    {
       
    }

    class NeedleBelly : IMammals, ILandHabitat
    {
        string IAnimal.Name() => "Иглобрюх";
        string IAnimal.NameSupplement() => "Иглобрюха";
        public string AttackManner() => " сделал бдыщ ";
    }
}
