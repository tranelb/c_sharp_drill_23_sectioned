using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_drill_23_sectioned;



public enum Temperature
{
    Freeze,
    Low,
    Warm,
    Boil
}

struct Customers
{
    private string name;
    private double balance;
    private int id;

    public void createCust(string n, double b, int i)
    {
        name = n;
        balance = b;
        id = i;
    }

    public void showCust()
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Balance : " + balance);
        Console.WriteLine("ID : " + id);
    }
}




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
            //Console.ReadLine();

            Temperature micTemp = Temperature.Low;

            Customers bob = new Customers();

            bob.createCust("Bob", 15.50, 12345);

            bob.showCust();

            int[] randArray = new int[5];

            //nullable type?
            int nullVar = randArray[4];

            addNumsDelgt varDelgtObj = new addNumsDelgt(Example_Delegate.addNumMeth);
            int result = varDelgtObj(2, 3);
            Console.WriteLine("Delegate result = " + result);

            Console.WriteLine("*-*-*-*-*-*-");
            MCDel_A delA_1 = new MCDel_A(Mulitcast_Delegate_A.DemoMethod1);
            MCDel_A delA_2 = new MCDel_A(Mulitcast_Delegate_A.DemoMethod2);
            MCDel_A delA_3 = new MCDel_A(Mulitcast_Delegate_A.DemoMethod3);
            MCDel_A delA_4 = delA_1 + delA_2 + delA_3;
            Console.WriteLine("pre delA_4() *-*-*-*-*-*-");
            delA_4();
            Console.WriteLine("post delA_4() *-*-*-*-*-*-");

            //string multResult = delA_4();
            Console.WriteLine("Multicast Delegate result = " + delA_4);

            MCDel_B delB_1 = new MCDel_B(Mulitcast_Delegate_B.DemoMethod1B);
            MCDel_B delB_2 = new MCDel_B(Mulitcast_Delegate_B.DemoMethod2B);
            MCDel_B delB_3 = new MCDel_B(Mulitcast_Delegate_B.DemoMethod3B);

            MCDel_B varDelObjB = new MCDel_B(Mulitcast_Delegate_B.DemoMethod1B);
            varDelObjB += Mulitcast_Delegate_B.DemoMethod2B;
            varDelObjB += Mulitcast_Delegate_B.DemoMethod3B;
            varDelObjB -= Mulitcast_Delegate_B.DemoMethod2B;

            Console.WriteLine("pre varDelObjB() *-*-*-*-*-*-");
            varDelObjB();
            Console.WriteLine("post varDelObjB() *-*-*-*-*-*-");

            Console.ReadLine();

        }

        abstract class Shape
        {
            public abstract double area();

            // An abstract class can contain complete or default code for methods
            public void sayHi()
            {
                Console.WriteLine("Hello");
            }
        }
        
        // A class can have many interfaces
        // An interface can't have concrete code
        public interface ShapeItem
        {
            double area();
        }

        class Rectangle : Shape
        {
            private double length;
            private double width;

            public Rectangle(double num1, double num2)
            {
                length = num1;
                width = num2;
            }

            public override double area()
            {
                return length * width;
            }

            // You can redefine many built in operators so that you can define what happens when you 
            // add to Rectangles
            public static Rectangle operator +(Rectangle rect1, Rectangle rect2)
            {
                double rectLength = rect1.length + rect2.length;
                double rectWidth = rect1.width + rect2.width;

                return new Rectangle(rectLength, rectWidth);

            }

        }

    }
}

