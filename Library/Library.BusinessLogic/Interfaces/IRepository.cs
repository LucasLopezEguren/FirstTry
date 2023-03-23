using Library.BusinessLogic.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLogic.Interfaces
{
    public interface IRepository<T>
    {
        public void Add(T t);
        public int Count();
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        public void Delete(int id);
    }
}
