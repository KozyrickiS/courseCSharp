using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            short implShort = Constants.implSbyte;
            int implInt = Constants.implByte + 13;
            double implDouble = Constants.implInt32 + 0.55;
            //explicit conversion
            byte explByte = (byte)(Constants.explInt + 6);
            int explIntTwo = (int)(Constants.explDouble); // explIntTwo = 3
            decimal explDecimal = (decimal)(Constants.explDoubleTwo);
            //boxing
            object boxObj = Constants.boxInt;
            //unboxing
            int unboxInt = (int)boxObj;

            //С# or CLR type
            Constants.TypeToConsole();
            Console.ReadKey();
        }
    }
}
