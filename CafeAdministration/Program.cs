namespace CafeAdministration
{
     class Program
    {
        static void Main(string[] args)
        {
            Table[] tables = { new Table(1, 5), new Table(2, 10), new Table(3, 20) };
            //Table table1 = new Table(1, 5); //Создание стола (Эти строки записаны выше)
            //Table table2 = new Table(2, 10);
            //Table[] tables = {table1, table2};

            bool isOpen = true;

            while (isOpen)
            {
                Console.WriteLine("Администрирование кафе.\n");

                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].ShowInfo();
                }

                Console.Write("\nВведите номер стола:");
                int userTable = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("\nВведите количество мест:");
                int userPlase = Convert.ToInt32(Console.ReadLine());

                bool isReserve = tables[userTable].Reserve(userPlase);

                if (isReserve)
                {
                    Console.WriteLine("Бронь прошла успешно.");
                }
                else
                {
                    Console.WriteLine("Ошибка брони");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }


    class Table
    {
        private int _number;
        private int _maxPlase;
        private int _freePlase;

        public Table(int number, int maxPlase)
        {
            _number = number;
            _maxPlase = maxPlase;
            _freePlase = maxPlase;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Стол - " + _number + ". Свободно мест - " + _freePlase + "/" + _maxPlase);
        }

        public bool Reserve(int plase) //Сюда принимается кол-во мест
        {
            bool isReserve = false;

            isReserve = _freePlase >= plase;

            if (isReserve) 
            {
                _freePlase -= plase;
                return isReserve;
            }
            else 
            {
                return isReserve;
            }
            
        }
    }

}