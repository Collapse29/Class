﻿using FileService;
using InHerit.Auto;

namespace InHerit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "1 - Вывод списка машин" + Environment.NewLine +
                "2 - Добавить машину" + Environment.NewLine +
                "3 - Сохранить данные" + Environment.NewLine +
                "4 - Выход из программы");
            //TS ts = new TS();//Создали переменную класса ts

            //ts.WriteData();

            //ts = new TS(5, 7); //Создаю новый объект класса

            //ts.WriteData();

            //ts.ChangeData(8, 10);// Меняю значения

            //ts.WriteData();

            //AutoBase afto = new AutoBase(5, 10, "Двигатель 1", "Nissan");

            //afto.WriteData();

            //afto.ChangeData(4, 8, "Двигатель 2", "Nissan");
            //afto.WriteData();
            //Console.WriteLine("*******");
            AutoPark autoPark = new AutoPark();

            //autoPark.AddCar(null);
            //autoPark.AddCar(new AutoBase(new Random().Next(0, 10), new Random().Next(0, 20), $"Двигатель  {new Random().Next(0, 100)}", "Kia"));
            //autoPark.AddCar(new AutoBase(new Random().Next(0, 10), new Random().Next(0, 20), "Двигатель", "Kia"));
            //autoPark.AddCar(new AutoBase(new Random().Next(0, 10), new Random().Next(0, 20), "Двигатель", "Kia"));
            //autoPark.WriteCars();
            //Console.WriteLine("*******");
            //autoPark.DeletCar(3);
            //autoPark.WriteCars();

            FileWorkService fileWorkService = new FileWorkService();

            string[] autoData = fileWorkService.ReadFile(@"D:\Учеба\C#\Class\InHerit\dataBase.txt");
            for (int currentRow = 0; autoData.Length > currentRow; currentRow++)
            {
                string line = autoData[currentRow];
                string[] element = line.Split('/');
                AutoBase newCar = new AutoBase(int.Parse(element[0]), int.Parse(element[1]), element[2], element[3]);
                autoPark.AddCar(newCar);
            }

            while (true)
            {
                bool result = int.TryParse(Console.ReadLine(), out int menu);
                if (result == true)
                {
                    switch (menu)
                    {
                        case 1:
                            autoPark.WriteCars();
                            break;
                        case 2:
                            Console.Write("Введите кол-во колес: ");
                            int wheel;
                            while (true)
                            {
                                bool resultWheel = int.TryParse(Console.ReadLine(), out wheel);
                                if (resultWheel == true)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели не число. Введите еще раз");
                                }
                            }
                            Console.Write("Введите кол-во сидушек: ");
                            int seat;
                            while (true)
                            {
                                bool resultSeat = int.TryParse(Console.ReadLine(), out seat);
                                if (resultSeat == true)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели не число. Введите еще раз");
                                }
                            }
                            Console.Write("Введите двигатель: ");
                            string en = (Console.ReadLine());
                            Console.Write("Введите марку: ");
                            string id = (Console.ReadLine());
                            AutoBase newCar = new AutoBase(wheel, seat, en, id);
                            autoPark.AddCar(newCar);
                            break;
                        case 3:
                            fileWorkService.WriteFile(@"D:\Учеба\C#\Class\InHerit\dataBase.txt", autoPark.ToString());
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Не знаю");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не число");
                }

            }

            //autoPark.WriteCars();
            //autoPark._autos[0].ChangeData(0,0,"","");(Поменять значение у машины, тут первая машина

            //foreach (string currentRow in autoData)
            //{
            //    string[] element = currentRow.Split('/');
            //    AutoBase newCar = new AutoBase(int.Parse(element[0]), int.Parse(element[1]), element[2], element[3]);
            //    autoPark.AddCar(newCar);
            //}
            //autoPark.ToString();
            //Console.WriteLine(autoPark.ToString());
            //fileWorkService.WriteFile(@"D:\Учеба\C#\Class\InHerit\dataBase.txt", autoPark.ToString());
        }

    }
}