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
            PrintMonster(baseMonster);

            ArmorDecorator baseWithArmor = new ArmorDecorator(baseMonster);
            PrintMonster(baseWithArmor);

            ShieldDecorator shield = new ShieldDecorator(baseWithArmor);
            PrintMonster(shield);

            QuickAttackDecorator quick = new QuickAttackDecorator(shield);
            PrintMonster(quick);
        }

        static void PrintMonster(IMonsterComponent monster)
        {
            Console.WriteLine("\n--------------------\nGetName:" + monster.GetName);
            Console.WriteLine("Attack: " + monster.GetAttack);
            Console.WriteLine("GetHealth: " + monster.GetHealth + "\n--------------------");
        }
    }
}
