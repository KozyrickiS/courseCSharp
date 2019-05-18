using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoDatabase
{
    interface IMotoRepository
    {
        Motorcycle GetMotorcycleByID(int id);
        Motorcycle GetMotorcycle(Motorcycle moto);
        void CreateMotorcycle(Motorcycle moto);
        void UpdateMotorcycle(Motorcycle moto);
        void DeleteMotorcycle(Motorcycle moto);
    }
}
