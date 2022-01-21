using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Entities.DTOs
{
    public class CarteDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AutorNume { get; set; }
        public int IdAutor { get; set; }
        public Autor Autor { get; set; }
        public List<CartePremiu> CartiPremii { get; set; }

        public CarteDTO(Carte carte)
        {
            this.Id = carte.Id;
            this.Name = carte.Name;
            this.AutorNume = carte.AutorNume;
            this.IdAutor = carte.IdAutor;
            this.Autor = carte.Autor;
            this.CartiPremii = new List<CartePremiu>();
        }
    }
}
