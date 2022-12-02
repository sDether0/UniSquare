namespace UniSquare
{
    public class Circle : Figure
    {
        private readonly double _radius;
        public Circle(double radius) 
        { 
            _radius = radius;
        }
        public override double GetSquare()
        {
            return Math.Round(Math.PI * _radius * _radius,3);
        }
    }
}
