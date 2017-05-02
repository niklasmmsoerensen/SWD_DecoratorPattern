namespace DecoratorPattern
{
    class ScorpionMonsterDecorator : MonsterDecorator
    {
        private string _scorpionName;
        private int _scorpionHealth;
        private double _attack;
        private double _attackMultiplier;

        public ScorpionMonsterDecorator(IMonsterComponent monster, string name, int health, double attack) : base(monster)
        {
            _scorpionName = name;
            _scorpionHealth = health;
            _attack = attack;
            _attackMultiplier = 1.5;
        }

        public override string GetName
        {
            get
            {
                string s = base.GetName + " " + _scorpionName + ", GET OVER HERE!";
                return s;
            }
        }
        public override int GetHealth
        {
            get { return _scorpionHealth + base.GetHealth; }
        }

        public override double GetAttack
        {
            get { return CalculateAttack() + base.GetAttack; }
        }

        private double CalculateAttack()
        {
            return _attack * _attackMultiplier;
        }
    }
}