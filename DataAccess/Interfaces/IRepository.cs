using Entities.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
   public interface IRepository<T> where T:IEntity
    {
        bool Create(T ent);
        bool Update(T ent);
        bool Delete(T ent);
        List<T> GetAll(Predicate<T> filter=null);
        T Get(Predicate<T> filter=null);
    }
}
