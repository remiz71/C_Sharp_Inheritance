using System;
using System.Collections.Generic;

namespace C_Sharp_Inheritance
{
    class CompoundShape: IDrawable,IPrintable

    {
    List<Shape> _shapes;

    //конструктор
    public CompoundShape()
    {
        _shapes = new List<Shape>();
    }

    public void AddShape(Shape shape)
    {
        _shapes.Add(shape);
    }

    public double getSquare()
    {
        Console.WriteLine("Площадь всех фигур равна:");
        double sum = 0;
        foreach (Shape shape in _shapes)
            sum += shape.square();
        return sum;
    }

    public override string ToString()
    {
        string res = "Составная фигура: \n";
        foreach (Shape shape in _shapes)
            res += shape.ToString() + "\n";
        return res;
    }

    public void Print()
    {
        foreach (var figure in _shapes) //var - определяет тип
        {
            if (figure is IPrintable) //если фигура реализует интерфейс
            {
                ((IPrintable) figure).Print(); //вызвать Print фигуры
            }
            else
            {
                Console.WriteLine("Figure does not implement this interface");
            }
        }
    }

    public void Draw()
    {
        foreach (var figure in _shapes) //var - определяет тип
        {
            if (figure is IDrawable) //если фигура реализует интерфейс
            {
                ((IDrawable) figure).Draw(); //вызвать Print фигуры
            }
            else
            {
                Console.WriteLine("Figure does not implement this interface");
            }
        }
    }
    }
}