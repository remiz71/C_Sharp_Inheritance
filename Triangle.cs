using System;

namespace C_Sharp_Inheritance
{
    class Triangle: Shape, IDrawable
    {
        private double _a { get; set; }
        private double _b { get; set; }
        private double _c { get; set; }
       
        //конструктор
        public Triangle() : base()
        {
            _a = _b = _c = 0;
        }

        public Triangle(string name, double a, double b, double c) : base(name)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        //метод ToString

        public override string ToString()
        {
            return base.ToString() + $",со сторонами a = {_a}, b = {_b}, c = {_c}";
        }

        //переопределение абстрактного метода
        public override double perimeter()
        {
            return _a + _b + _c;
        }
        public override double square()
        {
            if (_a==_b && _a==_c)
            {
                double S = Math.Sqrt(3) / 4 * (_a * _a);
                return S;
            }
            else if (_a==_b)
            {
                double S = (_c / 4) * Math.Sqrt(4 * (_a * _a) - (_c * _c));
                return S;
            }
            else
            {
                double per = (_a + _b + _c) / 2;
                double S =  Math.Sqrt(per * (per - _a) * (per - _b) * (per - _c));
                return S;
            }
        }

        public void Draw()
        {
            double per = (_a + _b + _c) / 2;
            double S = Math.Sqrt((per * (per - _a) * (per - _b) * (per - _c)));
            double height = 2 * S / _c;
            for (int i = 0; i <= height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
            
        }

        public void Print()
        {
            Console.WriteLine(this);
        }
    }
}