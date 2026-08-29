using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLearning.OOP.Polymosrphism
{
    public class MethodHiding
    {
        public void Test()
        {
            Console.WriteLine("Hi I am parent method and showing the example of Method over Hiding :");
        }
    }
    public class MethodHiding2 : MethodHiding
    {

        public new void Test()
        {
            Console.WriteLine("Hii I am method of child class");
        }
        public void ParentTest()
        {
            base.Test();
        }

        public static void Main()
        {
             
            MethodHiding methodHiding = new MethodHiding2();
            //methodHiding2.ParentTest();
            methodHiding.Test();
        }
    }

}
