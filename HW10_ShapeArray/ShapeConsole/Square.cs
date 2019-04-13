using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeConsole
{
    class Square : IShape
    {
        private readonly string name;
        private double side;
        public Square(double side)
        {
            name = "Square";
            this.side = side;
        }
        public void Draw()
        {
            Console.WriteLine($"Just imagine a square with side {this.side}");
        }
        public double Area()
        {
            double area = this.side * this.side;
            return area;
        }
        public void Info()
        {
            Console.WriteLine($"This is {name}. CLR Type is \"{GetType()}\". Square is {Area()}");
        }
    }
}
