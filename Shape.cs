namespace C_Sharp_Inheritance
{
    abstract class Shape
    {
        private string name;
        private double _p; //периметр
        private double _s; //площадь

        public double P { get; set; }
        public double S { get; set; }
        public string Name { get; set; }

        //конструкторы
        public Shape()
        {
            name = "Empty";
            _p = _s = 0;
        }
        public Shape(string name)
        {
            Name = name;
        }
        public Shape(string name, double p, double s)
        {
            Name = name;
            P = p;
            S = s;
        }

        //методы

        public override string ToString()
        {
            return Name + ": Периметр = " + perimeter().ToString() + ", Площадь = " + square().ToString();
        }

        public abstract double perimeter();
        public abstract double square();
    }
}