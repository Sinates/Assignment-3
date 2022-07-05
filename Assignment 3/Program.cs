using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
    }
        abstract class shape
        {
            abstract public double calculateArea();
            abstract public double calculateperimeter();
        }
    
        class circle :shape
        {
            static readonly double PI = 3.14;
            public double Radius{ get; set; }
                public override double calculateArea()
            {
                return PI * Radius * Radius;
            }
            public override double calculateperimeter()
            {
                return 2 * PI * Radius;

            }

       
    }
    class Rectangle : shape
    {
        public double Width { get; set; }
        public double Length{ get; set; }
        public override double calculateArea()
        {
            return Length*Width;
            }
        public override double calculateperimeter()
        {
            return 2 * (Length * Width);
        }
    }

       internal class program
        {
        static void Main(string[] args)
        {
            circle Circle = new circle(); 
            Rectangle rectangle= new Rectangle();
            Circle.Radius = 6;
            rectangle.Length = 6;
            rectangle.Width = 6;
            Console.WriteLine("Area of a circle-" + Circle.calculateArea());
            Console.WriteLine("Perimeterof a circle-" + Circle.calculateperimeter());
            Console.WriteLine("Area of a Rectangle-" + rectangle.calculateArea());
            Console.WriteLine("perimeter  of a rectange-" + rectangle.calculateArea());
            Console.ReadKey();
        }

        }
    }

