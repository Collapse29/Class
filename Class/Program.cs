namespace Class
{
     class Program
    {
        static void Main(string[] args)
        {
            MyClass tor = new MyClass();
            //MyClass Yu = tor;
            
            MyClass.A = 1;
            MyClass.MyProperty = 2;
            MyClass.WriteMyClass();
            MyClass.A = 5;
            tor.B = 7;
            MyClass.WriteMyClass() ;
        }
    }
    
       
}