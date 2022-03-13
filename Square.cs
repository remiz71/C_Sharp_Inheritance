using System;

namespace C_Sharp_Inheritance
{
    class Square: Shape,IPrintable
    {
        private double _a; //стороны прямоугольника
        public double A { get; set; }
      
        //конструктор
        public Square() : base()
        {
            _a = 0;
        }

        public Square(string name, double a) : base(name)
        {
            this._a = a;
        }

        //метод ToString

        public override string ToString()
        {
            return base.ToString() + $",со стороной a = {_a}";
        }

        //переопределение абстрактного метода
        public override double perimeter()
        {
            return P = _a * 4;
        }
        public override double square()
        {
            return S = _a * _a;
        }

        public void Print()
        {
            Console.WriteLine(this);  
        }
    }
}