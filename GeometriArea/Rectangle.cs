using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriArea
{
    internal class Rectangle : Geometri
    {
        public double Width1 { get; set; }
        public double Height1 { get; set; }


        public Rectangle()
        {
            Width1 = 4.6;
            Height1 = 2.1;

        }
        public override double Area()
        {
            return Width1 * Height1;
        }

    }
}
