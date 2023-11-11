using System;

namespace Self01
{
    public class Rectangle
    {
		private double _width;
		private double _height;

		public double Width
		{
			get { return _width; }
			set { _width = Math.Abs(value); }
		}

		public double Height
		{
			get { return _height; }
			set { _height = Math.Abs(value); }
		}

		public double Perimeter
        {
			get => 2 * (_height + _width);
		}

		public double Square
        {
			get => _height * _width;
		}

		public Rectangle(): this(1, 1) { }

        public Rectangle(double widht, double height)
        {
			Width = widht;
			Height = height;
        }

        public override string ToString()
        {
			return $"Width: {_width}, Height: {_height}";
        }

    }
}
