using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriArea
{
    internal class Ellipse : Geometri
    {
        public double HalfRadius1 { get; set; }
        public double HalfRadius2 { get; set; }

        public Ellipse()
        {
            HalfRadius1 = 5.2;
            HalfRadius2 = 7.5;
        }
        public override double Area()
        {
            return HalfRadius1 * HalfRadius2 * Math.PI;
        }
    }
}
