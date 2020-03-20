using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraestructure.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<ICollection<T>> GetAll();
        Task<T> GetById(long id);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T ientity);
    }
}
