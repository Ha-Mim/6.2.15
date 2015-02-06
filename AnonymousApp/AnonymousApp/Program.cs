using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var aStudent = new {Name = "Bristy", RegNo = "43646", Address = "Lalbag"};
            Console.WriteLine(aStudent.Name+" "+aStudent.RegNo+ " "+aStudent.Address);
            var bStudent = new {Phone = "32545", Email = "h@gmail.com"};
            Console.WriteLine(bStudent.Phone+ " "+bStudent.Email);
            var names = new[] { "Kanta", "Zamil", "Rupom" };

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();

        }
    }
}
