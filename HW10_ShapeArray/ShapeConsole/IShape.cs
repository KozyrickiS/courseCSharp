using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeConsole
{
    interface IShape
    {
        void Draw();
        double Area();
        void Info();
    }
}
