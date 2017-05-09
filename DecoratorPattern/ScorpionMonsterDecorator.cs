namespace DecoratorPattern
{
    class ScorpionMonsterDecorator : MonsterDecorator
    {

        public ScorpionMonsterDecorator(IMonsterComponent monster, string name, int health, int attack) : base(monster)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
        }

        public override string GetName
        {
            get
            {
                string s = base.GetName + " " + name + " Scorpion";
                return s;
            }
        }
        public override int GetHealth
        {
            get { return health + base.GetHealth; }
        }

        public override double GetAttack
        {
            get { return CalculateAttack() + base.GetAttack; }
        }

        private double CalculateAttack()
        {
            double _attackMultiplier = 1.5;
            return attack * _attackMultiplier;
        }
    }
}