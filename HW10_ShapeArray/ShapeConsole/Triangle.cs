using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeConsole
{
    class Triangle : IShape
    {
        private readonly string name;
        private double firstSide;
        private double secondSide;
        private double thirdSide;
        public Triangle(double side)
        {
            name = "Equilateral Triangle";
            this.firstSide = side;
            this.secondSide = side;
            this.thirdSide = side;
        }
        public Triangle(double equalSide, double thirdSide)
        {
            if (thirdSide > equalSide * 2)
             throw new ArgumentException("Isosceles Triangle with this sides can't exist"); 
            name = "Isosceles Triangle";
            this.firstSide = equalSide;
            this.secondSide = equalSide;
            this.thirdSide = thirdSide;
        }
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            double[] sides = new double[3] { firstSide, secondSide, thirdSide };
            double perimetr = firstSide + secondSide + thirdSide;
            foreach( var oneSide in sides)
            {
                if ( oneSide > perimetr - oneSide)
                    throw new ArgumentException("Isosceles Triangle with this sides can't exist");
            }
            name = "Triangle";
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }
        public void Draw()
        {
            Console.WriteLine($"Just imagine a triangle with sides {this.firstSide}, {this.secondSide} and {this.thirdSide}. Yes, it's difficult, but we believe in you");
        }

        public double Area()
        {
            double semiPer = (this.firstSide + this.secondSide + this.thirdSide) / 2;
            double area = Math.Sqrt(semiPer * (semiPer - this.firstSide) * (semiPer - this.secondSide) * (semiPer - this.thirdSide));
            return area;
        }
        public void Info()
        {
            Console.WriteLine($"This is {name}. CLR Type is \"{GetType()}\". Square is {Area()}");
        }
    }
}
