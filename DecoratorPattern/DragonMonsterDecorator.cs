namespace DecoratorPattern
{
    class DragonMonsterDecorator : MonsterDecorator
    {
        public DragonMonsterDecorator(IMonsterComponent monster) : base(monster)
        {
            this.name = " Blue Eyed White Dragon";
            this.attack = 100;
            this.health = 1000;
        }

        //GetName Override
        public override string GetName
        {
            get
            {
                string s = base.GetName + name;
                return s;
            }
        }
        //GetHealth Override
        public override int GetHealth
        {
            get { return health + base.GetHealth; }
        }
        //GetAttack Override
        public override double GetAttack
        {
            get { return attack + base.GetAttack; }
        }
    }
}