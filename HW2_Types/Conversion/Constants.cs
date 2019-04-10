using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Constants
    {
        //implicit 
        public const sbyte implSbyte = 2;
        public const byte implByte = 8;
        public const int implInt32 = 258;
        //explicit
        public const int explInt = 26;
        public const double explDouble = 3.50;
        public const double explDoubleTwo = 56.089;
        //boxing
        public const int boxInt = 777;
        //С# or CLR type
        public const sbyte sbyteCSharp = 10;
        public const SByte sbyteCLR = 11;
        public const short shortCSharp = 100;
        public const Int16 shortCLR = 101;
        public const int intCSharp = -156;
        public const Int32 intCLR = -256;
        public const long longCSharp = 987;
        public const Int64 longCLR = 999;
        public const byte byteCSharp = 250;
        public const Byte byteCLR = 251;
        public const ushort ushortCSharp = 257;
        public const UInt16 ushortCLR = 258;
        public const char charCSharp = 'c';
        public const Char charCLR = 'v';
        public const uint uintCSharp = 268;
        public const UInt32 uintCLR = 269;
        public const ulong ulongCSharp = 9988;
        public const UInt64 ulongCLR = 9989;
        public const float floatCSharp = 3.5f;
        public const Single floatCLR = 4.5F;
        public const double doubleCSharp = 5.22;
        public const Double doubleCLR = 52.2;
        public const decimal decimalCSharp = 1056.87M;
        public const Decimal decimalCLR = 695.5m;
        public const bool boolCSharp = true;
        public const Boolean boolCLR = false;
        public const string stringCSharp = "string";
        public const String stringCLR = "SystemString";

        public static void TypeToConsole()
        {
            Console.WriteLine(sbyteCSharp.GetType().FullName);
            Console.WriteLine(sbyteCLR.GetType().FullName);

            Console.WriteLine(shortCSharp.GetType().FullName);
            Console.WriteLine(shortCLR.GetType().FullName);

            Console.WriteLine(intCSharp.GetType().FullName);
            Console.WriteLine(intCLR.GetType().FullName);

            Console.WriteLine(longCSharp.GetType().FullName);
            Console.WriteLine(longCLR.GetType().FullName);

            Console.WriteLine(byteCSharp.GetType().FullName);
            Console.WriteLine(byteCLR.GetType().FullName);

            Console.WriteLine(ushortCSharp.GetType().FullName);
            Console.WriteLine(ushortCLR.GetType().FullName);

            Console.WriteLine(charCSharp.GetType().FullName);
            Console.WriteLine(charCLR.GetType().FullName);

            Console.WriteLine(uintCSharp.GetType().FullName);
            Console.WriteLine(uintCLR.GetType().FullName);

            Console.WriteLine(ulongCSharp.GetType().FullName);
            Console.WriteLine(ulongCLR.GetType().FullName);

            Console.WriteLine(floatCSharp.GetType().FullName);
            Console.WriteLine(floatCLR.GetType().FullName);

            Console.WriteLine(doubleCSharp.GetType().FullName);
            Console.WriteLine(doubleCLR.GetType().FullName);

            Console.WriteLine(decimalCSharp.GetType().FullName);
            Console.WriteLine(decimalCLR.GetType().FullName);

            Console.WriteLine(boolCSharp.GetType().FullName);
            Console.WriteLine(boolCLR.GetType().FullName);

            Console.WriteLine(stringCSharp.GetType().FullName);
            Console.WriteLine(stringCLR.GetType().FullName);

            object objectCSharp = "obj";
            Object objectCLR = 3.14;
            Console.WriteLine(objectCSharp.GetType().FullName); //String
            Console.WriteLine(objectCLR.GetType().FullName); //Double
        }
    }    
}
