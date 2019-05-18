using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoDatabase
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public int Odometer { get; set; }

        public Motorcycle()
        {
        }
        public Motorcycle(int id, string name, string model, int year, int odometer)
        {
            this.Id = id;
            this.Name = name;
            this.Model = model;
            this.Year = new DateTime(year, 01, 01);
            this.Odometer = odometer;
        }
    }
}
