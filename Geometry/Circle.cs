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

        private void MathArea()
        {
            Area = Math.PI * _radius * _radius;
        }
    }
}