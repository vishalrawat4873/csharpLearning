using System;
namespace csharpLearning
{
    public class PropertiesExample
    {
        // Auto-property
        public string Name { get; set; }

        // Property with private setter
        public int Id { get; private set; }

        // Property with validation
        private int marks;

        public int Marks
        {
            get
            {
                return marks;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    marks = value;
                }
                else
                {
                    Console.WriteLine("Marks must be between 0 and 100");
                }
            }
        }

        // Computed property
        public bool IsPassed
        {
            get
            {
                return Marks >= 40;
            }
        }

        // Method to set private Id
        public void SetId(int id)
        {
            Id = id;
        }
    }

    class Program1
    {
        static void Main()
        {
            PropertiesExample propertiesExample = new PropertiesExample();

            // Name property
            propertiesExample.Name = "Vishal";

            // Id can only be changed inside Student class
            propertiesExample.SetId(101);

            // Marks property
            propertiesExample.Marks = 75;

            Console.WriteLine("Name: " + propertiesExample.Name);
            Console.WriteLine("Id: " + propertiesExample.Id);
            Console.WriteLine("Marks: " + propertiesExample.Marks);
            Console.WriteLine("Passed: " + propertiesExample.IsPassed);
        }
    }

}

