using System;
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
        void Attack(IAnimal attacked)
        {
            Console.WriteLine(this.Name() + this.AttackManner() + attacked.NameSupplement() + "!");
        }
        bool Aqua() => false;

        bool Land() => false;



    }
    interface IAquaticHabitat : IAnimal
    {
        bool IAnimal.Aqua() => true;

    }
    interface ILandHabitat : IAnimal
    {
        bool IAnimal.Land() => true;
    }
}
