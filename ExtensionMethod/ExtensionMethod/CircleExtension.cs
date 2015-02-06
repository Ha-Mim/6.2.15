using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
   static class CircleExtension
    {
       public static double GetArea(this Circle aCircle)
       {
           return Math.PI*aCircle.Radious*aCircle.Radious;
       }
    }
}
