namespace DecoratorPattern
{
    class DragonMonsterDecorator : MonsterDecorator
    {
        private string _dragonName;
        private int _dragonHealth;
        private double _attack;

        public DragonMonsterDecorator(IMonsterComponent monster, string name, int health, double attack) : base(monster)
        {
            _dragonName = name;
            _dragonHealth = health;
            _attack = attack;
        }

        public override string GetName
        {
            get
            {
                string s = base.GetName + " " + _dragonName;
                return s;
            }
        }
        public override int GetHealth
        {
            get { return _dragonHealth + base.GetHealth; }
        }
        public override double GetAttack
        {
            get { return _attack + base.GetAttack; }
        }

    }
}