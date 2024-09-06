using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle("Треугольник", 3, 4, 5);
            Circle circle = new Circle("Круг", 3.14);

            Console.WriteLine(triangle.Calculate());
            Console.WriteLine(circle.Calculate());

            Console.ReadLine();
        }
    }
}
