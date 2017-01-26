using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_drill_23_sectioned
{
    public delegate void MCDel_A();

    class Mulitcast_Delegate_A
    {
        public static void DemoMethod1()
        {
            Console.WriteLine("Demo Method ONE Invoked");
        }

        public static void DemoMethod2()
        {
            Console.WriteLine("Demo Method TWO Invoked");
        }

        public static void DemoMethod3()
        {
            Console.WriteLine("Demo Method THREE Invoked");
        }

    }

    public delegate void MCDel_B();

    class Mulitcast_Delegate_B
    {
        public static void DemoMethod1B()
        {
            Console.WriteLine("Demo Method 1 BEE Invoked");
        }

        public static void DemoMethod2B()
        {
            Console.WriteLine("Demo Method 2 BEE Invoked");
        }

        public static void DemoMethod3B()
        {
            Console.WriteLine("Demo Method 3 BEE Invoked");
        }

    }


}
