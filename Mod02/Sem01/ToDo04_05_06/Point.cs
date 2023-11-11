using System;

namespace ToDo04_05_06
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y) { X = x; Y = y; }
        public Point() : this(0, 0) { } // конструктор умолчания

        public double Ro
        {
            get
            {
                // ToDo 04:
                // Теорема пифагора.
                return Math.Sqrt(X * X + Y * Y);
            }
        }
        public double Fi
        {
            get
            {
                // ToDo 05:
                if (X == 0 && Y == 0) return 0;

                if(X == 0) return Y > 0 ? (Math.PI / 2) : (3 * Math.PI / 2);
                
                if (X < 0) return Math.Atan2(Y, X) + Math.PI;

                if (Y >= 0) return Math.Atan2(Y, X);

                return Math.Atan2(Y, X) + 2 * Math.PI;
            }
        }

        public string PointData
        { 
            get
            {
                string maket = "X = {0:f2}; Y = {1:f2}; Ro = {2:f2}; Fi = {3:f2}";
                return string.Format(maket, X, Y, Ro, Fi);
            }
        }
    }
}
