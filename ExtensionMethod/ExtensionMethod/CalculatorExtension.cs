using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
   static class CalculatorExtension
    {
        public static double Subtract(this Calculator aCalculator, double firstNo, double secoundNo)
        {
            return firstNo - secoundNo;
        }
    }
}
