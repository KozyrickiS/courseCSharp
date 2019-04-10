using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrays myArray = new MyArrays();
            //First Task
            int[] arr1 = myArray.ManualArray(4);
            int[] arr2 = myArray.RadnomArray(4);
            myArray.SumOfArrays(arr1, arr2);
            //Second Task
            myArray.PutInArray(4);
            //Third Task
            myArray.ReverseArray(4);
            Console.ReadKey();
        }
    }
}
