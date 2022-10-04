using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.DbContexts
{
    public class CaitiDbContextFactory
    {
        private readonly string _connectionString;
        public CaitiDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public CaitiDbContext CreateDbContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(_connectionString).Options;
            return new CaitiDbContext(options);
        }
    }
}
