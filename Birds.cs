﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    interface IBirds : IAnimal
    {
    }
    class BeakTail : IBirds, ILandHabitat
    {

        string IAnimal.Name() => "Клювохвост";
        string IAnimal.NameSupplement() => "Клювохвоста";
        public string AttackManner() => " сделал кар ";




    }
}
