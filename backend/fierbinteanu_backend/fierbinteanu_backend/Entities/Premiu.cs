using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Entities
{
    public class Premiu
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public ICollection<CartePremiu> CartiPremii { get; set; }
    }
}
