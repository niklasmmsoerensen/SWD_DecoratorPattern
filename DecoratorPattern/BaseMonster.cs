namespace DecoratorPattern
{
    class BaseMonster : IMonsterComponent //concrecte implementation of MonsterComponent
    {
        private string name;
        private int health;

        public BaseMonster()
        {
            name = "Base Monster";
            health = 200;
        }
        public string GetName
        {
            get
            {
                return name;
            }
        }

        public int GetHealth
        {
            get
            {
                return health;
            }
        }
    }
}