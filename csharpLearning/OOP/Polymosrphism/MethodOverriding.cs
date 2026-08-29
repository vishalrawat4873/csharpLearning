using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLearning.OOP.Polymosrphism
{
    public class MethodOverriding
    {
        public virtual void myFunction()
        {
            Console.WriteLine("Hi I am parent class method showing the exaple of method overriding: ");
        }
    }

    public class SecondClassMethodOverriding : MethodOverriding
    {
        public override void myFunction()
        {
            Console.WriteLine("Hy I am child class method and I am changing the behaviour of base class");
        }
        public static void Main(string[] args)
        {
            //MethodOverriding ovr = new MethodOverriding();
            //ovr.myFunction();

            MethodOverriding s = new SecondClassMethodOverriding();
            s.myFunction();
        }

    }
}
