using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_projectAssignment
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;

        }

        public override double CalculateArea()
        {
            return  Math.PI* Radius *Radius;

        }
    }
    class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public Rectangle(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;

        }
        public override double CalculateArea()
        {
            return Length * Breadth;
        }

    }

        

   
}
