using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info($"Start programm {System.Reflection.Assembly.GetEntryAssembly()}");
            //or  Logger.Log.Info($"Start {System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName}");
            Circle circle = new Circle(4.14);
            Triangle triangle = new Triangle(2.33, 5.33, 4.44);
            Triangle triangle2 = new Triangle(2.33, 1);
            Triangle triangle3 = new Triangle(2.33);
            Square square = new Square(4.36);
            circle.Info();
            square.Info();
            triangle.Info();
            triangle2.Info();
            triangle3.Info();

            IShape[] shapes = Algorithm.ShapeArray();
            foreach (var shape in shapes)
            {
                shape.Info();
            }
            //or like that
            /*
            Circle circleR4 = new Circle(4);
            Circle circleR6n25 = new Circle(6.25);
            Square square12 = new Square(12);
            Triangle triangle3n45 = new Triangle(3.45);
            Triangle triangle3n5n6 = new Triangle(3, 5, 6);
            Triangle triangle4n5 = new Triangle(4, 5);
            Algorithm.ShapesInfo(circleR4, circleR6n25, square12, triangle3n45, triangle3n5n6, triangle4n5);
            */
            Console.ReadKey();
            Logger.Log.Info($"Successful completed { System.Reflection.Assembly.GetEntryAssembly()}");
        }
    }
}
