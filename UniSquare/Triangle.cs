using System.Drawing;

namespace UniSquare
{
    public class Triangle : Polygon
    {
        private double? _a;
        private double? _b; 
        private double? _c;
        private double?[] Sides => new[] { _a, _b, _c };

        private double? _base;
        private double? _height;

        public Triangle() { }

        /// <summary>
        /// Создает треугольник с тремя заданными сторонами
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        
        /// <summary>
        /// Создает треугольник с заданными высотой и основанием
        /// </summary>
        /// <param name="bas"></param>
        /// <param name="height"></param>
        public Triangle(double bas, double height)
        {
            _base = bas;
            _height = height;
        }

        public void SetSides(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public void SetHeightAndBase(double bas, double height)
        {
            _base = bas;
            _height = height;
        }

        public override void SetPoints(List<Point> points)
        {
            if(points.Count != 3)
            {
                throw new Exception("In a triangle must be a three points");
            }
            base.SetPoints(points);
        }

        ///<inheritdoc/>
        public override double GetSquare()
        {
            try
            {
                
                if (_base is { } bs && _height is { } h)
                {
                    return bs * h / 2;
                }
                if (_a is { } a &&
                    _b is { } b &&
                    _c is { } c)
                {
                    if (IsRectangular())
                    {
                        if (a == Sides.Max())
                        {
                            return b*c/2;
                        }
                        if (b == Sides.Max())
                        {
                            return a*c/2;
                        }
                        if (c == Sides.Max())
                        {
                            return a*b/2;
                        }
                    }
                    var p = (a + b + c) / 2;
                    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }
                return GetPointsSquare();
            }
            catch(Exception e)
            {
                throw new Exception("Not enough data for calculates",e); 
            }
        }


        /// <summary>
        /// Проверяет треугольник на наличие прямого угла
        /// </summary>
        /// <returns></returns>
        public bool IsRectangular()
        {
            if (_a is { } a &&
                _b is { } b && 
                _c is { } c)
            {
                if (a == Sides.Max())
                {
                    return (a * a) == (b * b) + (c * c);
                }
                if (b == Sides.Max())
                {
                    return (b * b) == (a * a) + (c * c);
                }
                if (c == Sides.Max())
                {
                    return (c * c) == (b * b) + (a * a);
                }
            }
            return false;
        }

    }
}
