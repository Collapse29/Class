using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InHerit
{
    internal class TS
    {
        internal int Wheel;
        internal int Seat;
        /// <summary>
        /// Конструктор по умолчанию(пустой)
        /// </summary>
        public TS()
        {
            Wheel = 0;
            Seat = 0;
        }
        /// <summary>
        /// Конструктор с входными параметрами
        /// </summary>
        /// <param name="wheel">кол-во кол</param>
        /// <param name="seat">кол-во сидуш</param>
        public TS(int wheel, int seat)
        {
            Wheel = wheel;
            Seat = seat;
        }
        /// <summary>
        /// Вывод
        /// </summary>
        public virtual void WriteData()
        {
            Console.WriteLine($"Колес - {Wheel}"); //Одно и то же
            Console.WriteLine("Сидушек - " +  Seat);
        }
        /// <summary>
        /// Метод который меняет значения
        /// </summary>
        /// <param name="wheel">кол. колес</param>
        /// <param name="seat">кол. сидушек</param>
        public virtual void ChangeData(int wheel, int seat)
        {
            Wheel = wheel;
            Seat = seat;
        }
    }
}
