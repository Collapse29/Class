using System.Collections;

namespace ComputerClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputerClub computerClub = new ComputerClub(8);
            computerClub.Work();
        }
    }
    class ComputerClub
    {
        private int _money = 0;
        private List<Computer> _computers = new List<Computer>();//Список компьютеров, все списки массивы делаем всегда private
        private Queue<SchoolBoy> _schoolBoys = new Queue<SchoolBoy>(); //Очередь

        public ComputerClub(int computerCount)
        {
            Random rand = new Random();

            for (int i = 0; i< computerCount; i++)
            {
                _computers.Add(new Computer(rand.Next(5, 15)));
            }
            CreateNewSchoolBoy(25);
        }
        private void CreateNewSchoolBoy(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                _schoolBoys.Enqueue(new SchoolBoy(rand.Next(100,250), rand));
            }
        }
        public void Work()
        {
            while (_schoolBoys.Count > 0)
            {
                Console.WriteLine($"У компьютерного клуба сейчас {_money} рублей, ждем нового клиента.");

                SchoolBoy schoolBoy = _schoolBoys.Dequeue();
                Console.WriteLine($"В очереди человек, он хочет купить {schoolBoy.DesiredMinutes} минут.");
                Console.WriteLine("\nСписок компьютеров:");
                ShowAllComputers();

                Console.Write("Вы предлгаете ему пк под номером - ");
                int computerNumber = Convert.ToInt32( Console.ReadLine() );

                if (computerNumber >= 0 && computerNumber< _computers.Count)
                {
                    if (_computers[computerNumber].IsBusy)
                    {
                        Console.WriteLine("Вы предложили клиенту компьютер который уже занят. Клиент ушел :(");
                    }
                    else
                    {
                        if (schoolBoy.CheckSolvency(_computers[computerNumber]))
                        {
                            Console.WriteLine("Пересчитав деньги клиент оплатил нужное время и сел за компьютер.");
                            _money += schoolBoy.ToPay();
                            _computers[computerNumber].TakeThePlace(schoolBoy); 
                        }
                        else
                        {
                            Console.WriteLine("У клиента не хватило денег, он ушел.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Вы сами не понимаете за какой пк его посадить. Клиент ушел!!!");
                }
                Console.WriteLine("Для того чтобы перейти к новому клиенту нажмите любую клавишу.");
                Console.ReadKey(); 
                Console.Clear();
                SkipMinute();
            }
        }
        public void SkipMinute()
        {
            foreach (var computer in _computers)
            {
                computer.SkipMinute(); 
            }
        }
        private void ShowAllComputers()
        {
            for (int i = 0; i < _computers.Count; i++)
            {
                Console.Write($"{i} - "); 
                _computers[i].ShowInfo();
            }
        }

    }
    class Computer
    {
        private SchoolBoy _schoolBoy;
        private int _minutesLeft;

        public int PriceForMinutes { get; private set; }
        public bool IsBusy
        {
            get
            {
                return _minutesLeft > 0;
            }
        }
        public Computer(int priceForMinutes)
        {
            PriceForMinutes = priceForMinutes;
        } 
        public void TakeThePlace(SchoolBoy schoolBoy)
        {
            _schoolBoy = schoolBoy;
            _minutesLeft = _schoolBoy.DesiredMinutes;
        }
        public void FreeThePlace()
        {
            _schoolBoy = null;
        }
        public void SkipMinute()
        {
            _minutesLeft--;
        }
        public void ShowInfo()
        {
            if (IsBusy)
                Console.WriteLine($"Компьютер занят. Осталось минут - {_minutesLeft}");
            else
                Console.WriteLine($"Компьютер свободен. Цена за минуту - {PriceForMinutes}");
        }
    }
    class SchoolBoy
    {
        private int _money;//Деньги
        private int _moneyToPay;

        public int DesiredMinutes { get; private set; }
        public SchoolBoy(int money, Random rand)
        {
            _money = money;
            DesiredMinutes = rand.Next(10,30);
        }
        public bool CheckSolvency(Computer computer)
        {
            _moneyToPay = computer.PriceForMinutes * DesiredMinutes;
            if (_money>= _moneyToPay)
            {
                return true;
            }
            else
            {
                _moneyToPay = 0;
                return false;
            }
        }

        public int ToPay()
        {
            _money -= _moneyToPay;
            return _moneyToPay;
        }
    }
    
}