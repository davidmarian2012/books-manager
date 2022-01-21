using fierbinteanu_backend.Data;
using fierbinteanu_backend.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Repositories.CarteRepository
{
    public class CarteRepository : GenericRepository<Carte>, ICarteRepository
    {
        public CarteRepository(FierbinteanuContext context) : base(context) { }
        public async Task<List<Carte>> GetAllBooks()
        {
            return await _context.Carti.ToListAsync();
        }
        public async Task<Carte> GetByName(string name)
        {
            return await _context.Carti.Where(a => a.Name.Equals(name)).FirstOrDefaultAsync();
        }

    }
}
