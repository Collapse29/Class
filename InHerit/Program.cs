using InHerit.Auto;

namespace InHerit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TS ts = new TS();//Создали переменную класса ts

            ts.WriteData();

            ts = new TS(5, 7); //Создаю новый объект класса

            ts.WriteData();

            ts.ChangeData(8, 10);// Меняю значения

            ts.WriteData();

            AutoBase afto = new AutoBase(5, 10, "Двигатель 1", "Nissan");

            afto.WriteData();

            afto.ChangeData(4, 8, "Двигатель 2", "Nissan");
            afto.WriteData();
            Console.WriteLine("*******");
            AutoPark autoPark = new AutoPark();

            autoPark.AddCar(null);
            autoPark.AddCar(new AutoBase(new Random().Next(0, 10), new Random().Next(0, 20),$"Двигатель  {new Random().Next(0, 100)}", "Kia"));
            autoPark.AddCar(new AutoBase(new Random().Next(0, 10), new Random().Next(0, 20), "Двигатель", "Kia"));
            autoPark.AddCar(new AutoBase(new Random().Next(0, 10), new Random().Next(0, 20), "Двигатель", "Kia"));
            autoPark.WriteCars();
            Console.WriteLine("*******");
            autoPark.DeletCar(3);
            autoPark.WriteCars();
        }

    }
}