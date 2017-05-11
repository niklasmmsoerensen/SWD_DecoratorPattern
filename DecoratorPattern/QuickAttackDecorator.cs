namespace DecoratorPattern
{
    class QuickAttackDecorator : MonsterDecorator
    {
        public QuickAttackDecorator(IMonsterComponent monster) : base(monster)
        {
            this.name = " (quick attack) ";
            this.attack = 0;
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