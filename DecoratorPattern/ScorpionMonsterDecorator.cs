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
        //GetName Override
        public override string GetName
        {
            get
            {
                string s = base.GetName + " " + name + " Scorpion";
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
            get { return CalculateAttack() + base.GetAttack; }
        }
        //Help method to calculate the attack based of a modifier
        private double CalculateAttack()
        {
            double _attackMultiplier = 1.5;
            return attack * _attackMultiplier;
        }
    }
}