﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeConsole
{
    class Circle : IShape
    {
        private readonly string name;
        private double radius;
        public Circle(double radius)
        {
            name = "Circle";
            this.radius = radius;
        }
        public void Draw()
        {
            Console.WriteLine($"Just imagine a circle with radius {this.radius}");
        }
        public double Area()
        {
            Logger.Log.Info($"Start output data for {name} to the console");
            double area = Math.PI * this.radius * this.radius;
            return area;
        }
        public void Info()
        {
            Logger.Log.Info($"Start calculation area for {name}");
            Console.WriteLine($"This is {name}. CLR Type is \"{GetType()}\". Square is {Area()}");
        }
    }
}
