using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Entities.DTOs
{
    public class AutorDTO
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public int YearOfBirth { get; set; }
        public Adresa Adresa { get; set; }
        public List<Carte> Carti { get; set; }

        public AutorDTO(Autor autor)
        {
            this.Id = autor.Id;
            this.Nume = autor.Nume;
            this.YearOfBirth = autor.YearOfBirth;
            this.Adresa = autor.Adresa;
            this.Carti = new List<Carte>();
        }
    }
}
