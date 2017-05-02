namespace DecoratorPattern
{
    class MonsterDecorator : IMonsterComponent
    {
        private IMonsterComponent _monsterComponent = null;

        public MonsterDecorator(IMonsterComponent monster)
        {
            _monsterComponent = monster;
        }

        public virtual string GetName //virtual so we can override in ConcreteDecorator
        {
            get { return _monsterComponent.GetName; }
        }

        public virtual int GetHealth //virtual so we can override in ConcreteDecorator
        {
            get { return _monsterComponent.GetHealth; }
        }
    }

    class DragonMonsterDecorator : MonsterDecorator
    {
        private string _dragonName;
        private int _dragonHealth;

        public DragonMonsterDecorator(IMonsterComponent monster, string name, int health) : base(monster)
        {
            _dragonName = name;
            _dragonHealth = health;
        }

        public override string GetName
        {
            get
            {
                string s = base.GetName + ":" + _dragonName;
                return s;
            }
        }
        public override int GetHealth
        {
            get { return _dragonHealth + base.GetHealth; }
        }
    }
}