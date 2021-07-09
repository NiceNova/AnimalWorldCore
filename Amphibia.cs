using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    interface IAmphibia : ILandHabitat, IAquaticHabitat
    {


    }

    class ClaweAdngleTooth : IAmphibia
    {
        string IAnimal.Name() => "Когтистый углозуб";
        string IAnimal.NameSupplement() => "Когтистого углозуба";
        public string AttackManner() => " поцарапал ушами ";

    }
}
