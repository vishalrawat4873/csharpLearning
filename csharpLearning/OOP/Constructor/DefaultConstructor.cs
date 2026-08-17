using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLearning.OOP.Constructor
{
    public class DefaultConstructor
    {
        int a;
        string s;
        bool b;
        public DefaultConstructor()
        {
                
        }
        public static void Main()
        {
            DefaultConstructor obj = new DefaultConstructor();
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.s);
            Console.WriteLine(obj.b);

        }
    }
}
