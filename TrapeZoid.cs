using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    internal class TrapeZoid : Shape
    {
        private readonly double value;
        private double _Upperbottom;
        private double _LowerBottom;
        private double _high;

        public double Upperbottom
        {
            get { return _Upperbottom; }
            set { _Upperbottom = value; }
        }
        public double High
        {
            get { return _high; }
            set{_high = value; }
        }
        public double Lowerbottom
        {
            get { return _LowerBottom; }
            set { _LowerBottom = value; }
        }
        public TrapeZoid() { }
        public TrapeZoid(double Upperbottom, double Lowerbottom, double High)
        {
            this.Upperbottom = Upperbottom;
            this.Lowerbottom = Lowerbottom;
            this.High = High;
            this.CountArea();
        }

        public override void CountArea()
        {
            double bottom = this.Upperbottom+this.Lowerbottom;
            this.area = (bottom * this.High) / 2;
        }

    }
}
