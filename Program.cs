using System;

namespace C_Sharp_Inheritance
{
    class Program
    {
        static void Test1()
        {
            //создать прямоугольник
            Rectangle rect = new Rectangle("Прямоугольник", 3, 2);
            Console.WriteLine(rect);
            Console.WriteLine();

            //создать квадрат
            Square sqr = new Square("Квадрат", 10);
            Console.WriteLine(sqr);
            Console.WriteLine();

            //создать треугольник

            Triangle trg = new Triangle("Треугольник", 12, 12, 12);
            Console.WriteLine(trg);
            Console.WriteLine();

            CompoundShape shp = new CompoundShape();
            shp.AddShape(new Triangle("Треугольник", 12, 12, 12));
            Console.WriteLine(shp);
            shp.AddShape(new Rectangle("Прямоугольник", 3, 2));
            Console.WriteLine(shp);
            Console.WriteLine(shp.getSquare());

        }
        static void Main(string[] args)
        {
            CompoundShape shp = new CompoundShape();
            shp.AddShape(new Triangle("Треугольник", 12, 12, 12));
            
            shp.AddShape(new Rectangle("Прямоугольник", 3, 2));
            
            shp.AddShape(new Square("Квадрат", 7));
            
            shp.Draw();
            Console.WriteLine();
            shp.Print();
        }
    }
}