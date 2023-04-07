namespace Inheritance
{
     class Program                                                                                              //Рыцарь и варвар являются войнами и у них все то же самое
                                                                                                                //что и у класса воин
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight(100,5,50);
            Barbarian barbarian = new Barbarian(100, 1, 20, 2);

            barbarian.TakeDamage(500);
            knight.TakeDamage(120);

            barbarian.ShowInfo();
            knight.ShowInfo();
        }
    }


    class Warrior
    {
        protected int Health;                                                                                   //Позволяем наследуемым классам использовать (protected)
        protected int Armor;
        protected int Damage;

        public Warrior(int health, int armor, int damage)                                                       //Конструктор для инициализации здоровья брони и урона
        {
            Health = health;
            Armor = armor;
            Damage = damage;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage - Armor;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Health);
        }
    }


    class Knight : Warrior                                                                                      
    {
        public Knight(int health, int armor, int damage) : base(health, armor, damage) { }     //Запрашиваем конст-ор из базового класса    
        public void Pray()
        {
            Armor += 2;
        }
    }

    class Barbarian : Warrior
    {
        public Barbarian(int health, int armor, int damage, int attackSpeed): base(health, armor, damage* attackSpeed)
        {

        }
        public void Waagh()
        {
            Armor -= 2;
            Health += 10;
        }
    }

}