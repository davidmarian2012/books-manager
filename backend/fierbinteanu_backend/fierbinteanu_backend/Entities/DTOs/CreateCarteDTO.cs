using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Entities.DTOs
{
    public class CreateCarteDTO 
    {
        public string Name { get; set; }
        public string AutorNume { get; set; }
        public Autor Autor { get; set; }
    }
}
