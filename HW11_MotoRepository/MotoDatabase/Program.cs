using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection.ConnectionInitialize();
            Logger.InitLogger();
            Logger.Log.Info($"Start programm {System.Reflection.Assembly.GetEntryAssembly()}");
            MotoRepository motoRepository = new MotoRepository();
            var motoToStaticGet = motoRepository.GetByID(3);
            Console.WriteLine($"Motorcycle: id - {motoToStaticGet.Id}, model - {motoToStaticGet.Model}, name - {motoToStaticGet.Name}, odometer - {motoToStaticGet.Odometer}, year - {motoToStaticGet.Year}");

            MotoSQLRepository motoSQLRepository = new MotoSQLRepository();
            var motoToGet = motoSQLRepository.GetMotorcycleByID(2);
            Console.WriteLine($"Motorcycle: id - {motoToGet.Id}, model - {motoToGet.Model}, name - {motoToGet.Name}, odometer - {motoToGet.Odometer}, year - {motoToGet.Year}");

            Motorcycle motoToCreate = new Motorcycle(7, "Honda", "Model34", 1986, 2300);
            motoSQLRepository.CreateMotorcycle(motoToCreate);
            var motoToCteate = motoSQLRepository.GetMotorcycleByID(7);
            Console.WriteLine($"Motorcycle: id - {motoToCteate.Id}, model - {motoToCteate.Model}, name - {motoToCteate.Name}, odometer - {motoToCteate.Odometer}, year - {motoToCteate.Year}");

            Motorcycle motoToDel = new Motorcycle(4, "Honda", "Model34", 1986, 2300);
            motoSQLRepository.DeleteMotorcycle(motoToDel);

            Motorcycle motoToUpdate = new Motorcycle(7, "Honda", "NewModel", 1999, 100);
            motoSQLRepository.UpdateMotorcycle(motoToUpdate);
            var motoUpdate = motoSQLRepository.GetMotorcycleByID(7);
            Console.WriteLine($"Motorcycle: id - {motoUpdate.Id}, model - {motoUpdate.Model}, name - {motoUpdate.Name}, odometer - {motoUpdate.Odometer}, year - {motoUpdate.Year}");
            Logger.Log.Info($"Successful completed { System.Reflection.Assembly.GetEntryAssembly()}");
            Connection.Connect.Close();
            Console.ReadKey();
        }
    }
}
