using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitTypeLocalVariableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 100;
            var b = "Hello World";
            
            var s1 = new Student();
            
            s1.Name = "Bithi";
            s1.Address = "Polton";
            var Students = new List<Student>();
            var numbers = new int[] {1, 2, 3};
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();

        }
    }
}
