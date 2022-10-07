using Caiti.Clases_BD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Caiti_BD.db");

        }

        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<Curso> Cursos { get; set; }


    }
}
