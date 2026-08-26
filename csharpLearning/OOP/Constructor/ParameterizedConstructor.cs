using System;

namespace csharpLearning.OOP.Constructor
{
    public class ParameterizedConstructor
    {
        int id;
        string name;

        public ParameterizedConstructor(int id, string  name)
        {
            this.id = id;
            this.name = name;
        }

        public void myFunction()
        {
            Console.WriteLine($"The Value of Id: {id} and the value of name{name}");
        }

        public static void Main()
        {
            ParameterizedConstructor obj = new ParameterizedConstructor(3, "Vishal");
            obj.myFunction();
        }
    }
}
