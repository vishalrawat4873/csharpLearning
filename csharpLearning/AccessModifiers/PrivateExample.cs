using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace csharpLearning.AccessModifiers
{
    public class PrivateExample
    {
        private double salary;
        public PrivateExample(double salary)
        {
            this.salary = salary;
        }
        public void MyFunction()
        {
            Console.WriteLine($"My Salary {salary}");
        }


        public static void Main()
        {
            PrivateExample obj = new PrivateExample(5000);
            obj.MyFunction();
        }

    }
     
}
