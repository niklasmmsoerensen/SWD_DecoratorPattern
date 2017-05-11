namespace DecoratorPattern
{
    class QuickAttackDecorator : MonsterDecorator
    {
        public QuickAttackDecorator(IMonsterComponent monster) : base(monster)
        {
            this.name = " (quick attack) ";
            this.attack = 0; //adds 250 attack
            this.health = 0; //adds no health
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
            get { return attack + base.GetAttack + QuickAttack(); }
        }

        private int QuickAttack()
        {
            return 250;
        }
    }
}