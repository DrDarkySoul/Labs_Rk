using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

        public Shape()
        {
        }

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

    [Serializable]
    public class Triangle : Shape
    {
        public double sideAB;
        public double sideBC;
        public double sideCA;

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

        public Triangle()
        {
        }

        public Triangle(string text, double AB, double BC, double CA) : base(text)
        {
            SideAB = AB;
            SideBC = BC;
            SideCA = CA;
        }
    }
    [Serializable]
    public class Square : Shape
    {
        public double side;

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

        public Square()
        { 
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
    [Serializable]
    public class Circle : Shape
    {
        public double radius;

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

        public Circle()
        {
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
            List<Triangle> triangleList = new List<Triangle>();
            List<Square> squareList = new List<Square>();
            List<Circle> circleList = new List<Circle>();

            XmlSerializer xmlSerializerTriangle = new XmlSerializer(typeof(List<Triangle>));
            XmlSerializer xmlSerializerSquare = new XmlSerializer(typeof(List<Square>));
            XmlSerializer xmlSerializerCircle = new XmlSerializer(typeof(List<Circle>));

            while (true)
            {
                if (File.Exists("triangels.xml"))
                {
                    Console.WriteLine("Существует сериализованные обьекты класса треугольник!");
                    using (FileStream fst = new FileStream("triangels.xml", FileMode.OpenOrCreate))
                    {
                        triangleList = (List<Triangle>)xmlSerializerTriangle.Deserialize(fst);

                        foreach (Triangle tr in triangleList)
                        {
                            Console.WriteLine("Объект десериализован");
                            Console.WriteLine("Сторона АВ: {0} \nСторона ВС: {1} \nСторона СА: {2}", tr.sideAB, tr.sideBC, tr.sideCA);
                        }
                    }
                }

                if (File.Exists("squares.xml"))
                {
                    Console.WriteLine("Существует сериализованные обьекты класса квадрат!");
                    using (FileStream fss = new FileStream("squares.xml", FileMode.OpenOrCreate))
                    {
                        squareList = (List<Square>)xmlSerializerSquare.Deserialize(fss);

                        foreach (Square sq in squareList)
                        {
                            Console.WriteLine("Объект десериализован");
                            Console.WriteLine("Сторона АВ: {0}", sq.side);
                        }
                    }
                }

                if (File.Exists("circles.xml"))
                {
                    Console.WriteLine("Существует сериализованные обьекты класса круг!");
                    using (FileStream fsc = new FileStream("circles.xml", FileMode.OpenOrCreate))
                    {
                        circleList = (List<Circle>)xmlSerializerCircle.Deserialize(fsc);

                        foreach (Circle cr in circleList)
                        {
                            Console.WriteLine("Объект десериализован");
                            Console.WriteLine("Радиус: {0}", cr.radius);
                        }
                    }
                }

                try
                {
                    Square square = new Square("Square");
                    Circle circle = new Circle("Circle");
                    Triangle triangle = new Triangle("Triangle");

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

                    using (FileStream fst = new FileStream("triangels.xml", FileMode.OpenOrCreate))
                    {
                        triangleList.Add(triangle);
                        xmlSerializerTriangle.Serialize(fst, triangleList);
                        Console.WriteLine("Объекты треугольники сериализованы");
                    }

                    using (FileStream fss = new FileStream("squares.xml", FileMode.OpenOrCreate))
                    {
                        squareList.Add(square);
                        xmlSerializerSquare.Serialize(fss, squareList);
                        Console.WriteLine("Объекты квадраты сериализованы");
                    }

                    using (FileStream fsc = new FileStream("circles.xml", FileMode.OpenOrCreate))
                    {
                        circleList.Add(circle);
                        xmlSerializerCircle.Serialize(fsc, circleList);
                        Console.WriteLine("Объекты круги сериализованы");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Ошибка: {0}", e.Message);
                }
            }
        }
    }
}
