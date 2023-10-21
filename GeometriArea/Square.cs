using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriArea
{
    internal class Square : Geometri
    {
        public double Length { get; set; }

        public Square()
        {
            Length = 8.88;
        }

        public override double Area()
        {
            return Length * Length;
        }
    }
}
