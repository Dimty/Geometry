namespace Geometry
{
    public class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            this._radius = radius;
            MathArea();
        }
// some info
        private void MathArea()
        {
            Area = Math.PI * _radius * _radius;
        }
    }
}