namespace DecoratorPattern
{
    class BaseMonster : IMonsterComponent //concrecte implementation of MonsterComponent
    {
        private string name;
        private int health;
        private int attack;

        public BaseMonster()
        {
            name = "Base Monster";
            health = 200;
            attack = 100;
        }
        public string GetName
        {
            get
            {
                string s = "(" + name + ")";
                return s;
            }
        }

        public int GetHealth
        {
            get
            {
                return health;
            }
        }
        public double GetAttack
        {
            get
            {
                return attack;
            }
        }
    }
}