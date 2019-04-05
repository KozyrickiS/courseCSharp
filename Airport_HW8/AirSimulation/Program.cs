using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation();
            simulation.HelloByTime();
            simulation.ArportSim();
            Console.ReadKey();
        }               
    }
}
