namespace Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fighter[] fighters = { new Fighter("Jhon", 500, 50, 0), new Fighter("Mark", 250, 20, 25), new Fighter("Zac", 150, 100, 10), new Fighter("Timi", 300,30,0)};

            int figterIndex;
            //Fighter Heavy = new Fighter("Jhon",500,50,0);
            //Fighter Medium = new Fighter("Mark", 250, 20, 25);

            for (int i  = 0; i < fighters.Length; i++)
            {
                Console.Write(i + " ");
                fighters[i].ShowStats();//Посмотреть всех бойцов

            }

            Console.Write("Выберите бойца правых ворот: ");
            figterIndex = Convert.ToInt32(Console.ReadLine());
            Fighter rightFighter = fighters[figterIndex];
            Console.Write("Выберите бойца левых ворот: ");
            figterIndex = Convert.ToInt32(Console.ReadLine());
            Fighter leftFighter = fighters[figterIndex];

            while (leftFighter.Health >0 && rightFighter.Health>0)
            {
                Console.WriteLine();
                leftFighter.TakeDamage(rightFighter.Damage);
                rightFighter.TakeDamage(leftFighter.Damage);

                leftFighter.ShowStats();
                rightFighter.ShowStats();
            }
        }
    }

    class Fighter
    {
        public string _name;
        private int _health;
        private int _damage;
        private int _armor;

        public int Health
        {
            get
            {
                return _health;
            }
        }

        public int Damage
        {
            get
            {
                return _damage;
            }
        }

        public Fighter(string name, int health, int damage, int armor)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _armor = armor;
        }

        public void ShowStats()
        {
            Console.WriteLine(_name + " HP - " + _health + " DMG - " + _damage + " ARMOR - " + _armor);
        }

        public void TakeDamage(int damage)
        {
            _health -= damage - _armor;
        }
    }

    
}