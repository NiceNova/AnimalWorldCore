﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    interface IAnimal
    {
        string Name();
        string NameSupplement();
        string AttackManner();
        //string DefencekManner();
        //void Move();
        //void eat();
        //void breathe();
        void attack(IAnimal attacked)
        {
            Console.Write(this.Name());
            Console.Write(this.AttackManner());
            Console.Write(attacked.NameSupplement());
        }

    }
    interface IAquaticHabitat
    {
        const bool Aqua = true;

    }
    interface ILandHabitat
    {
        const bool Land = true;
    }
}