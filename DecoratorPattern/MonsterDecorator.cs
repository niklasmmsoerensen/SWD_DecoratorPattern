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

        public virtual double GetAttack //virtual so we can override in ConcreteDecorator
        {
            get { return _monsterComponent.GetAttack; }
        }
    }
}