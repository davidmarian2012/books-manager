using fierbinteanu_backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Repositories.CarteRepository
{
    public interface ICarteRepository : IGenericRepository<Carte>
    {
        Task<Carte> GetByName(string name);
        Task<List<Carte>> GetAllBooks();
    }
}
