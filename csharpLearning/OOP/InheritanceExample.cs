using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLearning.OOP
{
    public class InheritanceExample
    {
        public InheritanceExample(int i) 
        {
            Console.WriteLine("I am parent class constructor"+ i);
        }
        public void myFunction()
        {
            Console.WriteLine("Hello I am Parent class method: ");
        }
    }

    public class InheritanceExampleSecond : InheritanceExample
    {
        public InheritanceExampleSecond(int i) : base(i)
        {
            
        }
        public static void Main()
        {

            InheritanceExampleSecond second = new InheritanceExampleSecond(13);
            second.myFunction();
        }
    }
}
