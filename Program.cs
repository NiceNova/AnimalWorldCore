using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rand = new Random();
                IAnimal[] NatureList = { new NeedleBelly(), new BeakTail(), new DesertRedBally(), new YellowShel(), new ClaweAdngleTooth(), new SpikeSwordBearer() };
                string[] ActionWords = { "Из куста выполз ", "С дерева свалился ", "Внезапно озверевший ", "Перепуганный ",
                "Криво шатающийся ", "Бегущий по полю ", "Очень удивившийся " };
                Console.Write(ActionWords[rand.Next(ActionWords.Length - 1)]);
                IAnimal attacking = NatureList[rand.Next(NatureList.Length - 1)];
                IAnimal defending = NatureList[rand.Next(NatureList.Length - 1)];
                attacking.attack(defending);
                Console.Write("!");
                Console.WriteLine();
                //string[] ActionAnswerWords = { "А в это ответ ", "Обалдевший от такого ", "А разъяренный ", "Испугавшийся ", "Шатающийся " };
                //Console.Write(ActionAnswerWords[rand.Next(NatureList.Length - 1)]);
                //defending.attack(attacking);
                //Console.Write("!");
                Console.WriteLine();
                Console.ReadKey();
            }         
        }
    }
}
