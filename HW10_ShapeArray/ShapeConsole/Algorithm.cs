using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeConsole
{
    class Algorithm
    {        
        public static IShape[] ShapeArray()
        {
            Logger.Log.Info("Start create shapes array");
            Console.WriteLine("Our array will consist of three figures: circle, squere and isosceles triangle");
            Console.WriteLine("Input the radius of Circle:");
            double.TryParse(Console.ReadLine(), out double radius);
            if (radius <= 0)
            {
                Logger.Log.Error("Wrong side of Circle");
                Console.WriteLine("Why did you do this to me?");
                return null;
            }
            Circle circle = new Circle(radius);
            Console.WriteLine("Input the side of Square:");
            double.TryParse(Console.ReadLine(), out double side);
            if (side <= 0)
            {
                Logger.Log.Error("Wrong side of Square");
                Console.WriteLine("Why did you do this to me?");
                return null;
            }
            Square square = new Square(side);
            Console.WriteLine("For Isosceles Triangle input the equal side:");
            double.TryParse(Console.ReadLine(), out double equalSide);
            if (equalSide <= 0)
            {
                Logger.Log.Error("Wrong side of Isosceles Triangle");
                Console.WriteLine("Why did you do this to me?");
                return null;
            }
            Console.WriteLine("For Isosceles Triangle input the third side:");
            double.TryParse(Console.ReadLine(), out double thirdSide);
            if (thirdSide <= 0)
            {
                Logger.Log.Error("Wrong side of Isosceles Triangle");
                Console.WriteLine("Why did you do this to me?");
                return null;
            }
            Triangle triangle = new Triangle(equalSide, thirdSide);
            IShape[] shapes = { circle, square, triangle };
            return shapes;
        }

        public static void ShapesInfo(params IShape[] shapes)
        {
            Logger.Log.Info("Start create shapes array");
            foreach (var shape in shapes)
            {
                shape.Info();
            }
        }
    }
}
