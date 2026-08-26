using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLearning.AccessModifiers
{
    internal class InternalExaplme
    {
        internal string name;
        
        public static void Main()
        {
            InternalExaplme internalExaplme = new InternalExaplme();
            internalExaplme.name = "Vishal Rawat";
            Console.WriteLine(internalExaplme.name);
        }
    }
}
