namespace DecoratorPattern
{
    class ShieldDecorator : MonsterDecorator
    {
        public ShieldDecorator(IMonsterComponent monster) : base(monster)
        {
            this.name = " (shield) ";
            this.health = 200; //adds 200 health
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
    }
}