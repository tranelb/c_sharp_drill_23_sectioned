using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_drill_23_sectioned
{
    class Program
    {
        //Overloading is when you have multiple methods in the same scope, with the same name but different signatures.
        public class test
        {
            public int getStuff(int id)
            {
                //string text3 = "Integer used: ";
                return id;
            }
            public string getStuff(string name)
            {
                string text4 = "String version used: ";
                return text4 + name;
            }
        }


        public class OverRideClass
        {
            public virtual string OverRideMethod(string var)
            {
                string text1 = "Default text from OverRideClass ";
                return text1 + var;
            }

        }

        public class OverRider : OverRideClass
        {
            public override string OverRideMethod(string var)
            {
                string text2 = "Override text from overrider ";
                return text2 + var;
            }

        }

        static void Main(string[] args)
        {
            test testVar = new test();
            Console.WriteLine(testVar.getStuff(7));
            //Console.WriteLine("test_test_test");
            test testVarStr = new test();
            Console.WriteLine(testVarStr.getStuff("seven"));
            OverRideClass try1 = new OverRideClass();
            Console.WriteLine(try1.OverRideMethod("dassdafsdf"));
            OverRider try2 = new OverRider();
            Console.WriteLine(try2.OverRideMethod("tasefffdgsdf"));
            Console.ReadLine();

        }
    }
}
