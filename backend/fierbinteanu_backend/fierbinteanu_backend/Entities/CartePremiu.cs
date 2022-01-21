using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Entities
{
    public class CartePremiu
    {
        public int IdCarte { get; set; }
        public Carte Carte { get; set; }
        public int IdPremiu { get; set; }
        public Premiu Premiu { get; set; }
    }
}
