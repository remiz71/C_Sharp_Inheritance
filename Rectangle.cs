using System;

namespace C_Sharp_Inheritance
{
    class Rectangle : Shape, IDrawable

    {
    private double _a, _b; //стороны прямоугольника
    public double A { get; set; }
    public double B { get; set; }

    //конструктор
    public Rectangle() : base()
    {
        _a = _b = 0;
    }

    public Rectangle(string name, double a, double b) : base(name)
    {
        this._a = a;
        this._b = b;
    }

    //метод ToString

    public override string ToString()
    {
        return base.ToString() + $",со сторонами a = {_a}, b = {_b}";
    }

    //переопределение абстрактного метода
    public override double perimeter()
    {
        return (_a + _b) * 2;
    }

    public override double square()
    {
        return _a * _b;
    }

    public void Draw()
    {
        for (int i = 0; i < _a; i++)
        {
            for (int j = 0; j < _b; j++)
            {
                Console.Write("*  ");
            }

            Console.WriteLine();
        }
    } 
    }
}