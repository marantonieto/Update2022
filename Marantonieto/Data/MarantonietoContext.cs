using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Marantonieto.Models;

namespace Marantonieto.Data
{
    public class MarantonietoContext : DbContext
    {
        public MarantonietoContext (DbContextOptions<MarantonietoContext> options)
            : base(options)
        {
        }

        public DbSet<Marantonieto.Models.Department> Department { get; set; }
    }
}
