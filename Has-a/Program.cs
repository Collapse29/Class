namespace Has_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Виталий");
            User user2 = new User("Сергей");
            List list = new List(new Task[] { new Task(user1, "Помыл машину"), new Task(user2, "Поменял колеса") });

            list.ShowAllTasks();
        }
    }

    class User
    {
        public string Name;

        public User(string name)
        {
            Name = name;
        }
    }

    class List
    {
        public Task[] Tasks;

        public List(Task[] tasks)
        {
            Tasks = tasks;
        }

        public void ShowAllTasks()
        {
            for(int i = 0; i< Tasks.Length; i++)
            {
                Tasks[i].ShowInfo();//У каждой задачи вызываем описание
            }
        }
    }

    class Task
    {
        public User Worker;
        public string Description;

        public Task(User worker, string description)
        {
            Worker = worker;
            Description = description;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Ответственный - " + Worker.Name + "\nОписание задачи: " + Description);
        }
    }
}