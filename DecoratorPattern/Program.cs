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
            BaseMonster baseMonster = new BaseMonster();
            Console.WriteLine("\n--------------------\nGetName:" + baseMonster.GetName);
            Console.WriteLine("Attack: " + baseMonster.GetAttack);
            Console.WriteLine("GetHealth: " + baseMonster.GetHealth + "\n--------------------");

            DragonMonsterDecorator dragon = new DragonMonsterDecorator(baseMonster);
            Console.WriteLine("\n--------------------\nGetName:" + dragon.GetName);
            Console.WriteLine("Attack: " + dragon.GetAttack);
            Console.WriteLine("GetHealth: " + dragon.GetHealth + "\n--------------------");

            ScorpionMonsterDecorator scorpion = new ScorpionMonsterDecorator(baseMonster, "King", 200, 20);
            Console.WriteLine("\n--------------------\nGetName:" + scorpion.GetName);
            Console.WriteLine("Attack: " + scorpion.GetAttack);
            Console.WriteLine("GetHealth: " + scorpion.GetHealth + "\n--------------------");
        }
    }
}
