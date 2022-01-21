using fierbinteanu_backend.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Repositories
{
    public interface IAutorRepository : IGenericRepository<Autor>
    {
        Task<Autor> GetByName(string name);
        Task<List<Autor>> GetAllAuthorsWithAdress();
        Task<Autor> GetByIdWithAdress(int id);
    }
}
