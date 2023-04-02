using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class MyClass
    {
        public MyClass() //Конструктор
        {
            YY = 9;
            WriteMyClass();
        }
        public readonly int YY;
        public static int A;
        public static int MyProperty { get; set; }

        public int B;
        public static void WriteMyClass()
        {

            Console.WriteLine(A + " " + MyProperty);
        }
    }
}
