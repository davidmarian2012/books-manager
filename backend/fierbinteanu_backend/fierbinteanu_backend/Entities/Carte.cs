using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Entities
{
    public class Carte
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AutorNume { get; set; }
        public int IdAutor { get; set; }
        public Autor Autor { get; set; }
        public ICollection<CartePremiu> CartiPremii { get; set; }

    }
}
