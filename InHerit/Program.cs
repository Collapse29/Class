using InHerit.Auto;

namespace InHerit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TS ts = new TS();//Создали переменную класса ts

            ts.WriteData();

            ts = new TS(5,7); //Создаю новый объект класса

            ts.WriteData();

            ts.ChangeData(8, 10);// Меняю значения

            ts.WriteData();

            AutoBase afto = new AutoBase(5,10,"Двигатель 1");

            afto.WriteData();

            afto.ChangeData(4, 8, "Двигатель 2");
            afto.WriteData();
        }
    }
}