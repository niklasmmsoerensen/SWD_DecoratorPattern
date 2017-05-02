using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    interface IMonsterComponent
    {
        //gets name of Monster
        string GetName { get;}
        //gets Health of Monster
        int GetHealth { get; }
        double GetAttack { get; }
    }
}
