using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Calculator();
            c1.Subtract(12, 6);
            var c2 = CalculatorExtension.Subtract(c1,23,45);
            var c3 = new Circle(12.3);
            c3.GetDiameter();
            c3.GetArea();
            var C4 = CircleExtension.GetArea(c3);
            var aValue = "Ha-Mim";
            var a = StringExt.GetFirstTwoChars(aValue);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(C4);
            Console.WriteLine(aValue);
            Console.WriteLine(a);
            Console.WriteLine(c1.Subtract(12, 6));
            Console.WriteLine(c3.GetDiameter());
            Console.WriteLine(c3.GetArea());
            Console.ReadKey();


        }
    }
}
