using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.AddEmployee();
            Developer developer = new Developer();
            //developer.GetConst();
            //developer.GetInfoAboutEmployment();

            developer.AddEmployee();
            developer.GetInfoAboutEmployment();
            Console.WriteLine("Developer age is " + developer.Age());
            //developer.GetInfo();
            Console.ReadKey();
        }
    }
}
