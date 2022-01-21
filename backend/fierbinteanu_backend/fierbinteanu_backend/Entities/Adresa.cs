using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Entities
{
    public class Adresa
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int IdAutor { get; set; }
        public Autor Autor { get; set; }
    }
}
