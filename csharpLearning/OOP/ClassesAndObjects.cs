using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharpLearning.OOP
{
     
    public class ClassesAndObjects // class
    {
        int i;
        bool b;
        string s;

        public static void Main()
        {
            Console.WriteLine("Hello I am class");
            ClassesAndObjects obj = new ClassesAndObjects(); //creating instance and calling constructor
            Console.WriteLine(obj.i);
            Console.WriteLine(obj.s);
            Console.WriteLine(obj.b);
        }
    }
}
