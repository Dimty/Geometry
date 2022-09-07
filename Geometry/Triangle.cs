using System.Diagnostics;

namespace Geometry
{
    public class Triangle : Shape, ITypeOfTriangle
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
            MathArea();
        }

        private void MathArea()
        {
            double p = GetPerimeter();
            Area = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        private double GetPerimeter()
        {
            return (_a + _b + _c) / 2;
        }

        public bool IsRectangular()
        {
            return (Math.Abs(_a - Math.Sqrt(Math.Pow(_b, 2) + Math.Pow(_c, 2))) == 0 ||
                    Math.Abs(_b - Math.Sqrt(Math.Pow(_a, 2) + Math.Pow(_c, 2))) == 0 ||
                    Math.Abs(_c - Math.Sqrt(Math.Pow(_b, 2) + Math.Pow(_a, 2))) == 0);
        }

        public bool IsSharpAngled()
        {
            throw new NotImplementedException("In develop -_-");
        }

        public bool IsObtuseAngle()
        {
            throw new NotImplementedException("In develop -_-");
        }
    }
}