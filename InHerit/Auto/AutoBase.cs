namespace InHerit.Auto
{
    internal class AutoBase : TS
    {
        protected string Name;
        protected string Engine; // создал поле для двигателя
        /// <summary>
        /// Конструктор по умолчанию и (:) вызывает базовый конструткор
        /// </summary>
        public AutoBase() : base()
        {
            Engine = "";
            Name = string.Empty;// пустая строка как выше
        }
        /// <summary>
        /// Конструктор который принимает значения и вызывает базовый конструткор 
        /// </summary>
        /// <param name="wheel">Колеса</param>
        /// <param name="seat">Сидушки</param>
        /// <param name="engine">Двигатель</param>
        public AutoBase(int wheel, int seat, string engine, string name) : base(wheel, seat)
        {
            Engine = engine;
            Name = name;
        }
        /// <summary>
        /// Переопределенный метод, который выводит данные с вызовом базового метода
        /// </summary>
        public override void WriteData()
        {
            Console.WriteLine($"Марка - {Name}");
            Console.WriteLine($"Двигатель - {Engine}"); 
            base.WriteData(); //вывод с базового класса

        }
        /// <summary>
        /// Переопределенный метод который меняет данные с вызовом базового метода
        /// </summary>
        /// <param name="wheel">Колеса</param>
        /// <param name="seat">Сидушки</param>
        /// <param name="engine">Двигатель</param>
        public virtual void ChangeData(int wheel, int seat, string engine, string name) 
        {
            base.ChangeData(wheel, seat);
            Engine = engine; //меняем значение в поле двигателя 
            Name = name;
        }

        public override string ToString()
        {
            //string car = Wheel.ToString() + "/" + Seat.ToString() + "/" + Engine + "/" + Name;
            return Wheel.ToString() + "/" + Seat.ToString() + "/" + Engine + "/" + Name;
        }
    }
}
