using fierbinteanu_backend.Data;
using fierbinteanu_backend.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Repositories
{
    public class AutorRepository : GenericRepository<Autor>, IAutorRepository
    {
        public AutorRepository(FierbinteanuContext context) : base(context) { }

        public async Task<List<Autor>> GetAllAuthorsWithAdress()
        {
            return await _context.Autori.Include(a => a.Adresa).ToListAsync();
        }

        public async Task<Autor> GetByIdWithAdress(int id)
        {
            return await _context.Autori.Include(a => a.Adresa).Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Autor> GetByName(string name)
        {
            return await _context.Autori.Where(a => a.Nume.Equals(name)).FirstOrDefaultAsync();
        }
    }
}
