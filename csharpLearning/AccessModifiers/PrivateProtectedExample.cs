using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharpLearning.AccessModifiers
{
    public class PrivateProtectedExample
    {
        private protected string name;
    }

    public class Manager1 : PrivateProtectedExample
    {
        public void Display()
        {
            Console.WriteLine(name);  
        }
    }
}
