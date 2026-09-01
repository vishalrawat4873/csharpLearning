using System;

namespace csharpLearning
{
    public struct StructureExample
    {
        int i;
        public StructureExample()
        {
            
        }
        public void Display()
        {
            Console.WriteLine("Method in structure"+ i);
        }

        public static void Main(string[] args) 
        {
            StructureExample example = new StructureExample();
            example.i = 10;
            example.Display();
        }
    }
}