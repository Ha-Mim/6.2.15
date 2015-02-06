using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Circle
    {
        public double Radious { set; get; }

        public Circle(double radious )
        {
            Radious = radious;
        }

        public double GetDiameter()
        {
            return 2*Radious;
        }
    }
}
