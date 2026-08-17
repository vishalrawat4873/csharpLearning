using System;

namespace csharpLearning.OOP.Constructor
{
    public class ParameterizedConstructor
    {
        public int i;
        public ParameterizedConstructor(int x)
        {
            i = x;
        }

        public void myFunction()
        {
            Console.WriteLine($"The Value of  is: {i}");
        }
        public static void Main()
        {
            ParameterizedConstructor obj = new ParameterizedConstructor(100);
            obj.myFunction();
        }
    }
}
