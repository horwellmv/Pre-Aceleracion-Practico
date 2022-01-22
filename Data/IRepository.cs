using PreAcceleration.HorwellMurillo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreAcceleration.HorwellMurillo.Data
{
    public interface IRepository<T> where T : class, IEntity // Interface para repositorios de manera generica con los metodos CRUD
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
