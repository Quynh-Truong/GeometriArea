using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriArea
{
    internal class Parallellogram : Geometri
    {
        public double BaseLength { get; set; }
        public double Height2 { get; set; }

        public Parallellogram() : base()
        {
            BaseLength = 15.14;
            Height = 12.1;
        }

        public override double Area()
        {
            return Height * BaseLength;
        }
    }
}
