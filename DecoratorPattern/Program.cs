using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DragonMonsterDecorator dragon = new DragonMonsterDecorator(new BaseMonster(), "Blue Eyes White Dragon", 300, 50);
            Console.WriteLine("\n--------------------\nGetName:" + dragon.GetName);
            Console.WriteLine("Attack: " + dragon.GetAttack);
            Console.WriteLine("GetHealth: " + dragon.GetHealth + "\n--------------------");

            ScorpionMonsterDecorator scorpion = new ScorpionMonsterDecorator(new BaseMonster(), "Scorpion", 200, 20);
            Console.WriteLine("\n--------------------\nGetName:" + scorpion.GetName);
            Console.WriteLine("Attack: " + scorpion.GetAttack);
            Console.WriteLine("GetHealth: " + scorpion.GetHealth + "\n--------------------");
        }
    }
}
