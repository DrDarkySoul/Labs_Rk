using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        private Double _sideAB;
        private Double _sideBC;
        private Double _sideCA;
        
        public Double sideAB
        {
            get { return _sideAB; }
            set 
            {
                if (value >= 0) _sideAB = value;
                else throw new Exception(" Value too small!");
                _sideAB = value;
            }
        }

        public Double sideBC
        {
            get { return _sideBC; }
            set
            {
                if (value >= 0) _sideBC = value;
                else throw new Exception(" Value too small!");
                _sideBC = value;
            }
        }

        public Double sideCA
        {
            get { return _sideCA; }
            set
            {
                if (value >= 0) _sideCA = value;
                else throw new Exception(" Value too small!");
                _sideCA = value;
            }
        }

        public Triangle(Double AB, Double BC, Double CA)
        {
           if (Math.Max(Math.Max(AB, BC), Math.Max(BC, CA))>=(Math.Min(AB, BC) + Math.Min(BC, CA)))
           {
               throw new Exception(" Encorrect input!");
           }
           else
           {
               _sideAB = AB;
               _sideBC = BC;
               _sideCA = CA;
           }
        }
    }

    public struct TriangleParams
    {
        public Double square;
        public Double angleA;
        public Double angleB;
        public Double angleC;
        public Double perimetr;
        public Double circumCircleRadius;
        public Double inCurcleRadius;
        public TriangleType Type;
    }

    public enum TriangleType
    {
        Usual,
        Equilateral,
        Isoscceles,
        Right
    }

  /*  class Ex 
    {
        public static delegate void C_W(String n);

        public static void Writeline(String str)
        {
            Console.WriteLine(str);
        }
        C_W cw = Writeline;

    }*/

    class Program
    {
        static void Main(string[] args)
        {
            String input;
            Double _AB = 0;
            Double _BC = 0;
            Double _CA = 0;
            Triangle first;
            TriangleParams first_params;
            bool repeat = true;
            while (repeat)
            {
                try
                {
                    Console.WriteLine(" Введи стороны треугольника:");
                    Console.WriteLine("AB -");
                    input = Console.ReadLine();
                    _AB = Convert.ToDouble(input);
                    Console.WriteLine("BC -");
                    input = Console.ReadLine();
                    _BC = Convert.ToDouble(input);
                    Console.WriteLine("CA -");
                    input = Console.ReadLine();
                    _CA = Convert.ToDouble(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(" Imposible to convert to Double {0}", e);
                    return;
                }
                if ((_AB != 0 && _BC != 0 && _CA != 0)&&
                    (_AB + _BC > _CA && _CA + _BC > _AB && _AB + _CA > _BC))
                    repeat = false;
                else
                    Console.WriteLine(" Введены некорректные стороны, попробуйте снова!");
            }

            first = new Triangle(_AB, _BC, _CA);

            first_params.perimetr = first.sideAB + first.sideBC + first.sideCA;
            first_params.square = Math.Sqrt(first_params.perimetr / 2
                                            * ((first_params.perimetr / 2) - first.sideAB)
                                            * ((first_params.perimetr / 2) - first.sideBC)
                                            * ((first_params.perimetr / 2) - first.sideCA));
            first_params.angleA = 180 / Math.PI *
                Math.Acos(
                (Math.Pow(first.sideCA, 2.0) +
                 Math.Pow(first.sideAB, 2.0) -
                 Math.Pow(first.sideBC, 2.0))
                 / (2 * first.sideCA * first.sideAB));
            first_params.angleB = 180 / Math.PI *
                Math.Acos(
                (Math.Pow(first.sideBC, 2.0) +
                 Math.Pow(first.sideAB, 2.0) -
                 Math.Pow(first.sideCA, 2.0))
                 / (2 * first.sideBC * first.sideAB));
            first_params.angleC = 180 - first_params.angleA - first_params.angleB;

            first_params.inCurcleRadius = first_params.square / (2 * first_params.perimetr);
            first_params.circumCircleRadius = (first.sideAB * first.sideBC * first.sideCA) / (4 * first_params.square);

            if (first.sideAB == first.sideBC && first.sideCA == first.sideBC && first.sideCA == first.sideAB)
            {
                first_params.Type = TriangleType.Equilateral;
            }
            else if (first_params.angleA == 90 || first_params.angleB == 90 || first_params.angleC == 90)
            {
                first_params.Type = TriangleType.Right;
            }
            else if (first.sideAB == first.sideBC || first.sideCA == first.sideBC || first.sideCA == first.sideAB)
            {
                first_params.Type = TriangleType.Isoscceles;
            }
            else
            {
                first_params.Type = TriangleType.Usual;
            }

            Console.WriteLine(" Вы задали треугольник со сторонами {0}, {1}, {2}", first.sideAB, first.sideBC, first.sideCA);
            Console.WriteLine("                       с углами {0:F}, {1:F}, {2:F}", first_params.angleA, first_params.angleB, first_params.angleC);
            Console.WriteLine("                       с периметром {0}", first_params.perimetr);
            Console.WriteLine("                       c площадью {0:F}", first_params.square);
            Console.WriteLine("                       c радиусом вписанной окружности {0:F}", first_params.inCurcleRadius);
            Console.WriteLine("                       c радиусом описанной окружности {0:F}", first_params.circumCircleRadius);
            if (first_params.Type == TriangleType.Equilateral)
                Console.WriteLine(" Треугольник равносторонний!");
            else if (first_params.Type == TriangleType.Right)
                Console.WriteLine(" Треугольник прямоугольный! ");
            else if (first_params.Type == TriangleType.Isoscceles)
                Console.WriteLine(" Треугольник равнобедренный! ");
        }
    }
}
