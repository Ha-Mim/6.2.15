using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambaExpression1
{
    class Program
    {
     

        private static void Main(string[] args)
        {
            Func<int, int> func1= x => x + 1;
            Console.WriteLine(func1.Invoke(2));
            
            Func<double, double, double> Multiply = (x, y) => x*y;
            Console.WriteLine(Multiply(2,3));
            Func<int, int> func7 = delegate(int x) { return x + 1; };
            Console.WriteLine(func7.Invoke(1));

            Console.ReadKey();
        }
    }
    }

