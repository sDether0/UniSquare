using System.Drawing;

namespace UniSquare
{
    public class Polygon : Figure
    {
        private List<Point>? _points;

        public Polygon()
        {

        }

        public override double GetSquare() => GetPointsSquare();

        public virtual void SetPoints(List<Point> points)
        {
            if (points.Count > 2)
            {
                _points = points;
                return;
            }
            throw new Exception("Must be at least three points");
        }

        /// <summary>
        /// Вычисляет площадь любой полигональной фигуры на плоскости по точкам
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public double GetPointsSquare()
        {
            if (_points == null)
            {
                throw new Exception("The points were not set");
            }

            double dsquare = 0;

            for (int i = 0; i < _points.Count; i++)
            {
                if (i < _points.Count - 1)
                {
                    dsquare += _points[i].X * _points[i + 1].Y;
                    dsquare -= _points[i + 1].X * _points[i].Y;
                }
                else
                {
                    dsquare += _points[i].X * _points[0].Y;
                    dsquare -= _points[0].X * _points[i].Y;
                }
            }
            return Math.Abs(dsquare) / 2;
        }
    }
}
