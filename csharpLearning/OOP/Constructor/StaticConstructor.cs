using System;

namespace csharpLearning.OOP.Constructor
{
    public class StaticConstructor
    {
        static string collegeName;
        
        //static Constructor
        static StaticConstructor()
        {
            collegeName = "Shivalik College Of Engineering";
            Console.WriteLine("static constructor called");
        }

        //Normal(Non static Constructor)

        public StaticConstructor()
        {
            Console.WriteLine("Normal Constructor called");
        }

        public void display()
        {
            Console.WriteLine(collegeName);
        }
        public static void Main() {
            StaticConstructor obj = new StaticConstructor();
            StaticConstructor obj1 = new StaticConstructor();
            obj.display();
            obj1.display();
        }
    }
}
