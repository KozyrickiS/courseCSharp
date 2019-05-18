using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoDatabase
{
    interface IRepository<T> where T : class
    {
        T GetByID(int id);
        T Get(T item);
        void Create(T item);
        void Update(T item);
        void Delete(T item);
    }
}
