namespace DecoratorPattern
{
    class ArmorDecorator : MonsterDecorator
    {
        public ArmorDecorator(IMonsterComponent monster) : base(monster)
        {
            this.name = " (armor) ";
            this.attack = 0; //adds no attack
            this.health = 500; //adds 500 health
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