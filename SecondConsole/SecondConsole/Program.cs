using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Realize
            //implicit conversion
            sbyte implSbyte = 2;
            short implShort = implSbyte;

            byte implByte = 8;
            int implInt = implByte + 13;

            int implInt32 = 258;
            double implDouble = implInt32 + 0.55;

            //explicit conversion
            int explInt = 26;
            byte explByte = (byte)(explInt + 6);

            double explDouble = 3.50;
            int explIntTwo = (int)(explDouble); // explIntTwo = 3

            double explDoubleTwo = 56.089;
            decimal explDecimal = (decimal)(explDoubleTwo);

            //boxing
            int boxInt = 777;
            object boxObj = boxInt;
            //unboxing
            int unboxInt = (int)boxObj;

            //4. С# or CLR type
            sbyte sbyteCSharp = 10;
            Console.WriteLine(sbyteCSharp.GetType().FullName);
            SByte sbyteCLR = 11;
            Console.WriteLine(sbyteCLR.GetType().FullName);

            short shortCSharp = 100;
            Console.WriteLine(shortCSharp.GetType().FullName);
            Int16 shortCLR = 101;
            Console.WriteLine(shortCLR.GetType().FullName);

            int intCSharp = -156;
            Console.WriteLine(intCSharp.GetType().FullName);
            Int32 intCLR = -256;
            Console.WriteLine(intCLR.GetType().FullName);

            long longCSharp = 987;
            Console.WriteLine(longCSharp.GetType().FullName);
            Int64 longCLR = 999;
            Console.WriteLine(longCLR.GetType().FullName);

            byte byteCSharp = 250;
            Console.WriteLine(byteCSharp.GetType().FullName);
            Byte byteCLR = 251;
            Console.WriteLine(byteCLR.GetType().FullName);

            ushort ushortCSharp = 257;
            Console.WriteLine(ushortCSharp.GetType().FullName);
            UInt16 ushortCLR = 258;
            Console.WriteLine(ushortCLR.GetType().FullName);

            char charCSharp = 'c';
            Console.WriteLine(charCSharp.GetType().FullName);
            Char charCLR = 'v';
            Console.WriteLine(charCLR.GetType().FullName);

            uint uintCSharp = 268;
            Console.WriteLine(uintCSharp.GetType().FullName);
            UInt32 uintCLR = 269;
            Console.WriteLine(uintCLR.GetType().FullName);

            ulong ulongCSharp = 9988;
            Console.WriteLine(ulongCSharp.GetType().FullName);
            UInt64 ulongCLR = 9989;
            Console.WriteLine(ulongCLR.GetType().FullName);

            float floatCSharp = 3.5f;
            Console.WriteLine(floatCSharp.GetType().FullName);
            Single floatCLR = 4.5F;
            Console.WriteLine(floatCLR.GetType().FullName);

            double doubleCSharp = 5.22;
            Console.WriteLine(doubleCSharp.GetType().FullName);
            Double doubleCLR = 52.2;
            Console.WriteLine(doubleCLR.GetType().FullName);

            decimal decimalCSharp = 1056.87M;
            Console.WriteLine(decimalCSharp.GetType().FullName);
            Decimal decimalCLR = 695.5m;
            Console.WriteLine(decimalCLR.GetType().FullName);

            bool boolCSharp = true;
            Console.WriteLine(boolCSharp.GetType().FullName);
            Boolean boolCLR = false;
            Console.WriteLine(boolCLR.GetType().FullName);

            string stringCSharp = "string";
            Console.WriteLine(stringCSharp.GetType().FullName);
            String stringCLR = "SystemString";
            Console.WriteLine(stringCLR.GetType().FullName);

            object objectCSharp = "obj";
            Console.WriteLine(objectCSharp.GetType().FullName); //String
            Object objectCLR = 3.14;
            Console.WriteLine(objectCLR.GetType().FullName); //Double

            Console.ReadKey();

        }
    }
}
