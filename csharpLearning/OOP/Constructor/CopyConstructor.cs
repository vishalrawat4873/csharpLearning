    using System;

    namespace csharpLearning.OOP.Constructor
    {
        public class CopyConstructor
        {
            int i;
            string s;
            bool b;

            public CopyConstructor(int i,string s, bool b)
            {
                this.i = i;
                this.s = s;
                this.b = b;
            }

            public CopyConstructor(CopyConstructor copyConstructor )
            {
                i = copyConstructor.i;
                s = copyConstructor.s;
                b = copyConstructor.b;
            }

            public void myFunction()
            {
                Console.WriteLine($"The Value of i is: {i} and Values of s is: {s} and value of b is: {b}");
            }
            public static void Main()
            {
                CopyConstructor obj = new CopyConstructor(100, "Vishal", false);
                CopyConstructor obj1 = new CopyConstructor(obj);
                obj.myFunction();
            }
        }
    }
