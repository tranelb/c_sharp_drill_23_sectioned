using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_drill_23_sectioned
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public long SSN {get; set; }

        public Human(string name, int age, long ssn)
        {
            this.Name = name;
            this.Age = age;
            this.SSN = ssn;
        }

        public void DoSomething()
        {
            Console.WriteLine("Hello my name is " + this.Name);
        }
        
    }
    class ExampleOfThis
    {
        static void Main()
        {
            Human personA = new Human("Tom", 45, 123456789);
            personA.DoSomething();
            Console.ReadLine();
        }

    }
}
