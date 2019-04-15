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
            Logger.Log.Info($"Start calculation area for {name}");
            double area = this.side * this.side;
            return area;
        }
        public void Info()
        {
            Logger.Log.Info($"Start output data for {name} to the console");
            Console.WriteLine($"This is {name}. CLR Type is \"{GetType()}\". Square is {Area()}");
        }
    }
}
