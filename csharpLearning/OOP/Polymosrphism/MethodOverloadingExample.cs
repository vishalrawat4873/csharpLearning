using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLearning.OOP.Polymosrphism
{
    public class MethodOverloadingExample
    {
        public void Test()
        {
            Console.WriteLine("first method: ");
        }
        public void Test(int i)
        {
            Console.WriteLine("second method: ");
        }
        public void Test(string s)
        {
            Console.WriteLine("Third method: ");
        }
        public void Test(int i , string s)
        {
            Console.WriteLine("Forth method: ");
        }
        public void Test(string s , int i)
        {
            Console.WriteLine("fifth method: ");
        }

        public static void Main()
        {
            MethodOverloadingExample example = new MethodOverloadingExample();
            example.Test("vishaal", 17);
        }
    }
}
