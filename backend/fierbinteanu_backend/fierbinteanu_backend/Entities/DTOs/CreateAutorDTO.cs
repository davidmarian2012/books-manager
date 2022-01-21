using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Entities.DTOs
{
    public class CreateAutorDTO
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        public Adresa Adresa { get; set; }
    }
}
