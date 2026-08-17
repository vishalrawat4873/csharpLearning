using System;

namespace csharpLearning.OOP.Constructor
{
    public class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("I am static Constructor: ");
        }
        public static void Main() {
            Console.WriteLine("Main Method Called:");
        }
    }
}
