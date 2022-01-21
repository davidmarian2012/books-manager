using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Repositories
{
    public interface IGenericRepository<TEntity>
    {

        //Get data
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetIdByAsync(int id);

        //Create
        void Create(TEntity entity);
        void CreateRange(IEnumerable<TEntity> entities);

        //Update
        void Update(TEntity entity);

        //Delete
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);

        //Save
        Task<bool> SaveAsync();
    }
}
