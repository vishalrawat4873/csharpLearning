using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLearning
{
    internal interface IInterfaceTest
    {
        void Add(int a, int b);
    }

    interface IInterfaceTest2 : IInterfaceTest 
    {
        void Sub(int a, int b);
    } 
    
    public class ImplementationInterface : IInterfaceTest2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Main()
        {
            ImplementationInterface implementationInterface = new ImplementationInterface();
            implementationInterface.Add(1, 2);
            implementationInterface.Sub(1, 2);
        }
    }
}
