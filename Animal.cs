using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    abstract class Animal
    {

        private string name;
        private string nameSupplement;
        private string attackManner;

        public string Name { get => name; set => name = value; }
        public string NameSupplement { get => nameSupplement; set => nameSupplement = value; }
        public string AttackManner { get => attackManner; set => attackManner = value; }


        //string DefencekManner();
        //void Move();
        //void eat();
        //void breathe();
        public void Attack(Animal attacked)
        {
            Console.WriteLine(this.Name + this.AttackManner + attacked.NameSupplement + "!");
        }
        public bool Aqua { get; set; }

        public bool Land { get; set; }



    }
    //interface IAquaticHabitat
    //{

    //    bool Aqua => true;

    //}
    //interface ILandHabitat
    //{
    //    bool Land => true;
    //}
}
