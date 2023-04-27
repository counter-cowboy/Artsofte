using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Artsofte.Models;

namespace Artsofte.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Employee> employee { get; set; }
    }
}
