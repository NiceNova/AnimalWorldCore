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
                IAnimal[] NatureList = { new NeedleBelly(), new BeakTail(), new DesertRedBally(), new YellowShel(), new ClaweAdngleTooth(), new SpikeSwordBearer() , new GillsSnout() , new TailSnout() };
                string[] ActionWords = { "Из куста выполз ", "С дерева свалился ", "Внезапно озверевший ", "Перепуганный ",
                "Криво шатающийся ", "Бегущий по полю ", "Очень удивившийся " };

                //IAnimal attacking = new BeakTail();
                //IAnimal defending = new SpikeSwordBearer();

                IAnimal attacking = NatureList[rand.Next(NatureList.Length)];
                IAnimal defending = NatureList[rand.Next(NatureList.Length)];
                if (((attacking.Land() ==  true) && (defending.Land() == true)) || ((attacking.Aqua() == true) && (defending.Aqua() == true)))
                {
                    Console.Write(ActionWords[rand.Next(ActionWords.Length - 1)]);
                    attacking.Attack(defending);

                }
                else if (attacking.Land() != defending.Land())
                {
                    if (defending.Land())
                    {
                        Console.Write(defending.Name() + " убежал от " + attacking.NameSupplement());
                        Console.WriteLine();
                    }
                    else if (defending.Aqua())
                    {
                        Console.Write(defending.Name() + " уплыл от " + attacking.NameSupplement());
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(" Случилось что то странное!");
                    }
                }

                        //string[] ActionAnswerWords = { "А в это ответ ", "Обалдевший от такого ", "А разъяренный ", "Испугавшийся ", "Шатающийся " };
                        //Console.Write(ActionAnswerWords[rand.Next(NatureList.Length - 1)]);
                        //defending.attack(attacking);
                        //Console.Write("!");
                        //Console.WriteLine();
                Console.ReadKey();
            }         
        }
    }
}
