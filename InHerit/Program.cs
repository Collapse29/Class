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
        }
    }
}