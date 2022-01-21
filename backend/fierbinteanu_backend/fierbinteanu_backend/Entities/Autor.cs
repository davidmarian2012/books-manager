using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Entities
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public int YearOfBirth { get; set; }
        public Adresa Adresa { get; set; }
        public ICollection<Carte> Carti { get; set; } 
    }
}
