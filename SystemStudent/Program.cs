using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemStudent
{
    public class Rectangle:Figure
    {
        public double a, b;
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Прямоугольник со сторонами: {a} и {b}");
            Console.WriteLine(GetP()+"\n"+GetS()+"\n");
        }
        public override string GetP()
        {
            return $"Периметр прямоугольника: {2*(a+b)}";
        }
        public override string GetS()
        {
            return $"Площадь прямоугольника: {a*b}";
        }
    }
    public class Circle:Figure
    {
        public double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Круг с радиусом: {r}");
            Console.WriteLine(GetP() + "\n" + GetS() + "\n");
        }
        public override string GetP()
        {
            return $"Периметр круга: {2 *Math.PI*r}";
        }
        public override string GetS()
        {
            return $"Площадь круга: {Math.PI*r*r}";
        }
    }
    public class Triangle:Figure
    {
        public double a, h, partA;//partA - переменная, являющаяся составной частью стороны а треугольника и катетом
                                  //прямоугольного треугольника, созданного с помощью опущенной высоты h на сторону а
        public double B { get { return Math.Sqrt(h * h + partA * partA); } }
        public double C { get { return Math.Sqrt(h * h + (a - partA) * (a - partA)); } }
        public Triangle(double a, double h, double partA)
        {
            this.a = a;
            this.h = h;
            this.partA = partA;
            if (partA > a) this.partA = a;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Треугольник со сторонами: {a}, {B} и {C}");
            Console.WriteLine(GetP()+"\n"+GetS()+"\n");
        }
        public override string GetP()
        {
            return $"Периметр треугольника: {a+B+C}";
        }
        public override string GetS()
        {
             return $"Площадь треугольника: {a*h/2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[]
            {
                new Triangle(45, 40, 40),
                new Circle(23),
                new Triangle(31, 5, 10),
                new Triangle(478, 167, 200),
                new Rectangle(1, 6),
                new Rectangle(54, 9),
                new Rectangle(30, 30)
            };
            foreach (Figure f in figures)
                f.GetInfo();

            Console.ReadKey();
        }
    }
}
