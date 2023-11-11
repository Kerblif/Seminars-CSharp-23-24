using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self02
{
    public class Circle
    {
		private double _r;

		public double R
		{
			get => _r;
			set { _r = Math.Max(value, 0); }
		}

        public double Square
        {
            get => Math.PI * _r * _r;
        }

        public Circle() : this(1) { }

        public Circle(double r)
        {
            R = r;
        }
    }
}
