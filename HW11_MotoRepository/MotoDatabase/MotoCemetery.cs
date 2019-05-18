using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoDatabase
{
    public static class MotoCemetery
    {
        public static Motorcycle[] MotoGrave()
        {
            Motorcycle[] graves = new Motorcycle[10];
            Motorcycle moto1 = new Motorcycle(1, "Honda", "model", 2000, 100);
            graves[0] = moto1;
            Motorcycle moto2 = new Motorcycle(2, "Honda", "model2", 2001, 120);
            graves[1] = moto2;
            Motorcycle moto3 = new Motorcycle(3, "Honda", "model4", 2002, 130);
            graves[2] = moto3;
            Motorcycle moto4 = new Motorcycle(4, "Honda", "model6", 2003, 150);
            graves[3] = moto4;
            Motorcycle moto5 = new Motorcycle(5, "Honda", "model8", 2004, 170);
            graves[4] = moto5;
            return graves;

        }
    }
}
