﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.GetConst();
            manager.GetInfoAboutEmployment();

            Console.ReadKey();
        }
    }
}
