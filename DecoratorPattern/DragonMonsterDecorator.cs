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
        public override string GetName
        {
            get
            {
                string s = base.GetName + name;
                return s;
            }
        }
        public override int GetHealth
        {
            get { return health + base.GetHealth; }
        }
        public override double GetAttack
        {
            get { return attack + base.GetAttack; }
        }

    }
}