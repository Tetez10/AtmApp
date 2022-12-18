using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetAtmApp.Models;

namespace AspNetAtmApp.Data
{
    public class AspNetAtmAppContext : DbContext
    {
        public AspNetAtmAppContext (DbContextOptions<AspNetAtmAppContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetAtmApp.Models.User> User { get; set; } = default!;
    }
}
