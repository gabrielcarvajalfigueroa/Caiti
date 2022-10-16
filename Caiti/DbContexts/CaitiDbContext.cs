using Caiti.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.DbContexts
{
    public class CaitiDbContext : DbContext
    {
        public CaitiDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Professor> Professors { get; set; }

        public DbSet<Subject> Subjects { get; set; }
    }
}
