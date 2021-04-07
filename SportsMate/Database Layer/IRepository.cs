using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsMate.Database_Layer
{
    public interface IRepository<T>
    {
        public void Create(T entity);
        public T GetById(int id);
        public void Delete(T entity);
        public void DeleteById(int id);
        public void Update(T entity);
    }
}
