using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.DbContexts
{
    public class CaitiDesignTimeDbContextFactory : IDesignTimeDbContextFactory<CaitiDbContext>
    {
        public CaitiDbContext CreateDbContext(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Source=caiti.db").Options;
            return new CaitiDbContext(options);
        }
    }
}
