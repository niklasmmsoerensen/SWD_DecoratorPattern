namespace DecoratorPattern
{
    class ArmorDecorator : MonsterDecorator
    {
        public ArmorDecorator(IMonsterComponent monster) : base(monster)
        {
            this.name = " (armor) ";
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
    }
}