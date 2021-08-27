using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    class Amphibia : Animal/*, ILandHabitat, IAquaticHabitat*/
    {
        
    }

    class ClaweAdngleTooth : Amphibia
    {
        public ClaweAdngleTooth() 
        {
            Name = "Когтистый углозуб";
            NameSupplement = "Когтистого углозуба";
            AttackManner = " поцарапал ушами ";
            Aqua = true;
            Land = true;
        }

        public ClaweAdngleTooth( string name, string nameSupplement, string attackManner)
        {
            Name = name;
            NameSupplement = nameSupplement;
            AttackManner = attackManner;
            Aqua = true;
            Land = true;

        }


    }
}
