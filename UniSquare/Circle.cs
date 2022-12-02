namespace UniSquare
{
    public class Circle : Figure
    {
        private readonly double _radius;

        /// <summary>
        /// Создает круг с заданным радиусом
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius) 
        { 
            _radius = radius;
        }
        
        ///<inheritdoc/>
        public override double GetSquare()
        {
            return Math.Round(Math.PI * _radius * _radius,3);
        }
    }
}
