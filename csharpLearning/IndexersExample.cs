using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLearning
{
    internal class IndexersExample
    {
        int id;
        string name, departmentName, city, location;
        double salary;
        public IndexersExample(int id, string name, string departmentName, string city, string location, double salary)
        {
            this.id = id;
            this.name = name;
            this.departmentName = departmentName;
            this.city = city; this.location = location; 
            this.salary = salary;
        }
        public object this[int index]
        {
            get
            {
                if(index == 0) { return id; }
                else if(index == 1) { return name; }
                else if(index == 2) { return departmentName; }
                else if(index == 3) { return city; }
                else  if(index == 4) { return location; }
                else if(index == 5) { return salary; }
                else { return null; };
            }
            set
            {
                if(index == 0)
                    id = (int)value;
                else if(index == 1)
                    name = (string)value;


            }
        }
    }
    public class IndexersProgram1
    {
        public static void Main()
        {
            IndexersExample indexersExample = new IndexersExample(1,"vishal","Microsoft","Dehradun","sighniwala",1324);
            Console.WriteLine(indexersExample[0]);
            Console.WriteLine(indexersExample[1]);
            Console.WriteLine(indexersExample[2]);
            Console.WriteLine(indexersExample[3]);
            Console.WriteLine(indexersExample[4]);
            Console.WriteLine(indexersExample[5]);

            Console.WriteLine();

            indexersExample[0] = 2;
            indexersExample[1] = "vishal rawat";
            Console.WriteLine(indexersExample[0]);
            Console.WriteLine(indexersExample[1]);

        }
    }
}
