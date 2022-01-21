using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Entities
{
    public class Role : IdentityRole<int>
    {
        public ICollection<UserRole> UserRole { get; set; }
    }
}
