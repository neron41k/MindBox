using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox
{
    public abstract class Figure
    {
        public string FigureName { get; set; }

        public Figure(string FigureName)
        {
            this.FigureName = FigureName;
        }
        public abstract double Calculate();
    }
    public class Triangle : Figure
    {
        public double ab { get; private set; }
        public double bc { get; private set; }
        public double ac { get; private set; }

        public Triangle(string FigureName, double ab, double bc, double ac) : base(FigureName)
        {
            if (ab < 0 || bc < 0 || ac < 0)
            {
                throw new ArgumentException($"Ошибка: сторона треугольника не может быть меньше нуля.\nТакой треугольник не может существовать!");
            }
            else if (ab > (bc + ac) || bc > (ab + ac) || ac > (ab + bc))
            {
                throw new ArgumentException($"Ошибка: одна из сторон больше, чем сумма двух других.\nТакой треугольник не может существовать!");
            } 
            else
            {
                this.ab = ab;
                this.bc = bc;
                this.ac = ac;
            }
        }
        public override double Calculate() 
        {
            double p = (ab + bc + ac) / 2; //Полупериметр
            double S = Math.Round(Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac))); //Формула Герона
            return S;
        }
        public bool IsRightTriangle()
        {
            bool corners = 
                (ab == Math.Sqrt(bc) + Math.Sqrt(ac)) 
                || bc == Math.Sqrt(ab) + Math.Sqrt(ac) 
                || ac == Math.Sqrt(ab) + Math.Sqrt(bc);
            return corners;
        }
    }
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public Circle(string FigureName, double Radius) : base(FigureName)
        {
            this.Radius = Radius;
        }
        public override double Calculate()
        {
            double S = Math.Round(Math.PI * Math.Sqrt(Radius));
            return S;
        }
    }

}
