using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAndCollectionInitialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var bStudent = new Student() {Name = "Ha-Mim", RegNo = "786"};
            List<Student> students = new List<Student>()
            {
                new Student() {Name = "Orthy", RegNo = "324"},
                new Student() {Name = "Subir", RegNo= "132"}
            };
            foreach (var astudent in students)
            {
                Console.WriteLine(astudent.Name+ " " + astudent.RegNo);
               
            }
            Console.ReadLine();
        }
        }
    }

