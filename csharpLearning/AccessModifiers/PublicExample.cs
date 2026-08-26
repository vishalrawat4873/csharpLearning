using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLearning.AccessModifiers
{
    public class PublicExample
    {
        public string name;

        public void MyFunction()
        {
            Console.WriteLine($"My Name is: {name}");
        }



        public static void Main()
        {
            PublicExample obj = new PublicExample();
            obj.name = "Vishal Rawat";
            obj.MyFunction();

           
        }
    }
      
    
}
