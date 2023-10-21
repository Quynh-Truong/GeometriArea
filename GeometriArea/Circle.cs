using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriArea
{
    internal class Circle : Geometri
    {
        public double Radius { get; set; }

        public Circle() : base()
        {
            Radius = 5.8;
        }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
