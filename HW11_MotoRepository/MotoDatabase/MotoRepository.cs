using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoDatabase
{
    class MotoRepository : IRepository<Motorcycle>
    {
        public Motorcycle Get(Motorcycle item)
        {
            Logger.Log.Info($"Start getting motorcycle {item} from Array");
            foreach (Motorcycle motorcycle in MotoCemetery.MotoGrave())
            {
                if (motorcycle == item)
                {
                    Logger.Log.Info($"Getting motorcycle with id: {item.Id}");
                    return motorcycle;
                }
            }
            Logger.Log.Error($"Motorcycle with id {item.Id} doesn't exist");
            return null;
        }

        public Motorcycle GetByID(int id)
        {
            Logger.Log.Info($"Start getting motorcycle with id: {id} from Array");
            foreach (Motorcycle motorcycle in MotoCemetery.MotoGrave())
            {
                if (motorcycle.Id == id)
                {
                    Logger.Log.Info($"Getting motorcycle with id: {id}");
                    return motorcycle;
                }
            }
            Logger.Log.Error($"Motorcycle with id {id} doesn't exist");
            return null;
        }

        public void Create(Motorcycle item)
        {
            Logger.Log.Info($"Start creating motorcycle {item} in Array");
            bool flag = false;
            for (int i = 0; i < MotoCemetery.MotoGrave().Length; i++)
            {
                if (MotoCemetery.MotoGrave()[i] == null)
                {
                    Logger.Log.Info($"Motorcycle {item} create in Array");
                    MotoCemetery.MotoGrave()[i] = item;
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Logger.Log.Error($"Motorcycle {item} don't create. DB are full");
                Console.WriteLine("Motorcycle don't create. DB are full");
            }
        }

        public void Delete(Motorcycle item)
        {
            Logger.Log.Info($"Start deleting motorcycle {item} in Array");
            bool flag = false;
            for (int i = 0; i < MotoCemetery.MotoGrave().Length; i++)
            {
                if (MotoCemetery.MotoGrave()[i] == item)
                {
                    Logger.Log.Info($"Motorcycle {item} delete from Array");
                    MotoCemetery.MotoGrave()[i] = null;
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Logger.Log.Error($"Motorcycle with id {item.Id} doesn't exist");
                Console.WriteLine("This Motorcycle doesn't exist");
            }
        }

        public void Update(Motorcycle item)
        {
            Logger.Log.Info($"Start update motorcycle {item} in Array");
            bool flag = false;
            for (int i = 0; i < MotoCemetery.MotoGrave().Length; i++)
            {
                if (MotoCemetery.MotoGrave()[i].Id == item.Id)
                {
                    Logger.Log.Info($"Motorcycle {item} update in Array");
                    MotoCemetery.MotoGrave()[i] = item;
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Logger.Log.Error($"Motorcycle with id {item.Id} doesn't exist");
                Console.WriteLine("This Motorcycle doesn't exist");
            }
        }
    }
}
