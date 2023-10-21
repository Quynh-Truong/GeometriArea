using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriArea
{
    internal abstract class Geometri
    {
        public double Width { get; set; }
        public double Height { get; set; }


        public abstract double Area();
    }
}
