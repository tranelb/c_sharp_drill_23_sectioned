using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_drill_23_sectioned
{
    public delegate int addNumsDelgt(int num1, int num2);
    class Example_Delegate
    {
        public static int addNumMeth(int num1, int num2)
        {
            return num1 + num2;

        }
        /*
        public static void Main()
        {
            addNumsDelgt varDelgtObj = new addNumsDelgt(addNumMeth);
            int result = varDelgtObj(2,3);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        */
    }
}
