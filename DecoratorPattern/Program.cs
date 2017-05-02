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
            DragonMonsterDecorator dragon = new DragonMonsterDecorator(new BaseMonster(), "Blue Eyes White Dragon", 300);
            Console.WriteLine("GetName\n" + dragon.GetName);
            Console.WriteLine("GetHealth\n" + dragon.GetHealth);
        }
    }
}
