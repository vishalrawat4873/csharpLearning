using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLearning.AccessModifiers
{
    public class ProtectedExample
    {
        protected string employeeName;
       // public ProtectedExample(string name)
        //{
           // this.employeeName = name;
       // }
    }
    public class Manager : ProtectedExample 
    {
        public Manager(string name)
        {
            employeeName = name;
        }

        public void MyFunction()
        {
            Console.WriteLine($"Employee Name Is {employeeName} ");
        }

        public static void Main() 
        {
            Manager obj = new Manager("Vishal Rawat");
            obj.MyFunction();
        }
    }
}
