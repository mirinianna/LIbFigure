using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyFigure
{
    public class Area_unknown
    {
        public double AreaUnknownSides(double radius)
        {
            return Math.PI * radius * radius;
        }
        public double AreaUnknownSides(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    public interface IFigure
    {
        double Area();
    }
    public class Circle : IFigure
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle()
        {
            this.radius = 0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Area()
        {
            return Math.PI * radius * radius;
        }
        public double Area(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
    public class Triangle : IFigure
    {
        private double a;
        private double b;
        private double c;
        public double A
        {
            get { return A; }
            set { A = value; }
        }
        public double B
        {
            get { return B; }
            set { B = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public Triangle()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public double Area(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public bool IsRightAngledTriangle()
        {
            double[] sid = { a, b, c };
            Array.Sort(sid);
            if (c * c == a * a + b * b)
                return true;
            else
                return false;
        }
        public bool IsRightAngledTriangle(double a, double b, double c)
        {
            double[] sid = { a, b, c };
            Array.Sort(sid);
            if (c * c == a * a + b * b)
                return true;
            else
                return false;
        }
    }
}
