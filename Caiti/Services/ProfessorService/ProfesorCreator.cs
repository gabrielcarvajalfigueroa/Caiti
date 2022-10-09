using Caiti.DbContexts;
using Caiti.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Services.ProfessorService
{
    public class ProfesorCreator : IProfessorControl
    {
        private readonly CaitiDbContextFactory _dbContextFactory;

        public ProfesorCreator(CaitiDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task CreateProfessor(Professor professor)
        {
            using (CaitiDbContext context = _dbContextFactory.CreateDbContext())
            {
                await Task.Delay(3000);

                context.Professors.Add(professor);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Professor>> GetAllProfessors()
        {
            using (CaitiDbContext context = _dbContextFactory.CreateDbContext())
            {
                await Task.Delay(3000);

                IEnumerable<Professor> professors = await context.Professors.ToListAsync();

                return professors;
            }
        }
    }
}
