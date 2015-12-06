using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    public abstract class Shape
    {
        protected string name;
        protected double perimeter;
        protected double area;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public abstract double Perimeter {get; set;}

        public abstract double Area {get; set;}

        public abstract double GetPerimeter();

        public abstract double GetArea();

        public Shape(string text)
        {
            name = text;
        }

        public static double operator +(Shape shape_1, Shape shape_2)
        {
            return (shape_1.Area + shape_2.Area);
        }

        public static double operator -(Shape shape_1, Shape shape_2)
        {
            return (shape_1.Area - shape_2.Area);
        }

        public static double operator *(Shape shape_1, Shape shape_2)
        {
            return (shape_1.Area * shape_2.Area);
        }

        public static double operator /(Shape shape_1, Shape shape_2)
        {
            return (shape_1.Area / shape_2.Area);
        }

        public static bool operator <(Shape shape_1, Shape shape_2)
        {
            return (bool)(shape_1.Area < shape_2.Area);
        }

        public static bool operator >(Shape shape_1, Shape shape_2)
        {
            return (bool)(shape_1.Area > shape_2.Area);
        }
    }

    public class Triangle : Shape
    {
        private double sideAB;
        private double sideBC;
        private double sideCA;

        public double SideAB
        {
            get
            {
                return sideAB;
            }

            set 
            {
                if (value <= 0)
                    throw new Exception("Сторона треугольника не может быть отрицательной!");

                sideAB = value;
            }
        }

        public double SideBC
        {
            get
            {
                return sideBC;
            }

            set
            {
                if (value <= 0)
                    throw new Exception("Сторона треугольника не может быть отрицательной!");

                sideBC = value;
            }
        }

        public double SideCA
        {
            get
            {
                return sideCA;
            }

            set
            {
                if (value <= 0)
                    throw new Exception("Сторона треугольника не может быть отрицательной!");

                sideCA = value;
            }
        }

        public override double Perimeter
        {
            get
            {
                return GetPerimeter();
            }

            set
            {
                if(value <= 0)
                    throw new Exception("Периметр треугольника не может быть отрицательным!");

                perimeter = value;
            }
        }

        public override double Area
        {
            get
            {
                return GetArea();
            }

            set
            {
                if (value <= 0)
                    throw new Exception("Площадь треугольника не может быть отрицательной!");

                area = value;
            }
        }

        public override double GetPerimeter()
        {
            double perimeter = sideAB + sideBC + sideCA;

            if (perimeter <= 0)
                throw new Exception("Периметр треугольника не может быть отрицательным!");

            return perimeter;
        }

        public override double GetArea()
        {
            double p = 0.5 * GetPerimeter();

            double square = Math.Sqrt(p * (p - sideAB) * (p - sideBC) * (p - sideCA));

            if(square == 0)
                throw new Exception("Площадь треугольника не может быть равна 0!");

            return square;
        }

        public Triangle(string text) : base(text)
        {
        }

        public Triangle(string text, double AB, double BC, double CA) : base(text)
        {
            SideAB = AB;
            SideBC = BC;
            SideCA = CA;
        }
    }

    public class Square : Shape
    {
        private double side;

        public double Side
        {
            get
            {
                return side;
            }

            set
            {
                if (value <= 0)
                    throw new Exception("Сторона квадрата не может быть отрицательной!");

                side = value;
            }
        }

        public override double Perimeter
        {
            get
            {
                return GetPerimeter();
            }

            set
            {
                if(value <= 0)
                    throw new Exception("Периметр квадрата не может быть отрицательным!");

                perimeter = value;
            }
        }

        public override double Area
        {
            get
            {
                return GetArea();
            }

            set
            {
                if (value <= 0)
                    throw new Exception("Площадь квадрата не может быть отрицательной!");

                area = value;
            }
        }

        public override double GetPerimeter()
        {
            double perimeter = 4.0 * side;

            if (perimeter <= 0)
                throw new Exception("Периметр квадрата не может быть отрицательным!");

            return perimeter;
        }

        public override double GetArea()
        {
            double square = Math.Pow(side, 2);

            if (square == 0)
                throw new Exception("Площадь квадрата не может быть равна 0!");

            return square;
        }

        public Square(string text) : base(text)
        {
        }

        public Square(string text, double s) : base(text)
        {
            Side = s;
        }
    }

    public class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value <= 0)
                    throw new Exception("Радиус окружности не может быть отрицательным!");

                radius = value;
            }
        }

        public override double Perimeter
        {
            get
            {
                return GetPerimeter();
            }

            set
            {
                if (value <= 0)
                    throw new Exception("Длина окружности не может быть отрицательной!");

                perimeter = value;
            }
        }

        public override double Area
        {
            get
            {
                return GetArea();
            }

            set
            {
                if (value <= 0)
                    throw new Exception("Площадь окружности не может быть отрицательной!");

                area = value;
            }
        }

        public override double GetPerimeter()
        {
            double perimeter = 2.0 * Math.PI * radius;

            if (perimeter <= 0)
                throw new Exception("Длина окружности не может быть отрицательной!");

            return perimeter;
        }

        public override double GetArea()
        {
            double square = Math.PI * Math.Pow(radius, 2);

            if (square == 0)
                throw new Exception("Площадь окружности не может быть равна 0!");

            return square;
        }

        public Circle(string text) : base(text)
        {
        }

        public Circle(string text, double r) : base(text)
        {
            Radius = r;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle triangle = new Triangle("Triangle");
                Square square = new Square("Square");
                Circle circle = new Circle("Circle");

                Console.WriteLine("===================================================================\n");

                Console.WriteLine("Треугольник:\n\n");

                Console.WriteLine("Введите сторону треугольника AB: ");
                triangle.SideAB = double.Parse(Console.ReadLine().ToString());

                Console.WriteLine("\nВведите сторону треугольника BC: ");
                triangle.SideBC = double.Parse(Console.ReadLine().ToString());

                Console.WriteLine("\nВведите сторону треугольника CA: ");
                triangle.SideCA = double.Parse(Console.ReadLine().ToString());

                Console.WriteLine("\n===================================================================\n");

                Console.WriteLine("Квадрат:\n\n");

                Console.WriteLine("Введите сторону квадрата: ");
                square.Side = double.Parse(Console.ReadLine().ToString());

                Console.WriteLine("\n===================================================================\n");

                Console.WriteLine("Окружность:\n\n");

                Console.WriteLine("Введите радиус окружности: ");
                circle.Radius = double.Parse(Console.ReadLine().ToString());

                Console.WriteLine("\n===================================================================\n");

                Console.WriteLine("Треугольник:");
                Console.WriteLine("Периметр: {0}", triangle.Perimeter);
                Console.WriteLine("Площадь: {0}\n", triangle.Area);

                Console.WriteLine("Квадрат:");
                Console.WriteLine("Периметр: {0}", square.Perimeter);
                Console.WriteLine("Площадь: {0}\n", square.Area);

                Console.WriteLine("Окружность:");
                Console.WriteLine("Длина: {0}", circle.Perimeter);
                Console.WriteLine("Площадь: {0}\n", circle.Area);

                Console.WriteLine("Треугольник + Квадрат = {0}", (triangle + square));
                Console.WriteLine("Треугольник - Окружность = {0}", (triangle - circle));
                Console.WriteLine("Квадрат * Окружность = {0}", (square * circle));
                Console.WriteLine("Квадрат / Треугольник = {0}", (square / triangle));
                Console.WriteLine("Квадрат < Окружность = {0}", (square < circle));
                Console.WriteLine("Квадрат > Окружность = {0}", (square > circle));
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Ошибка: {0}", e.Message);
            }

            Console.ReadKey();
        }
    }
}
