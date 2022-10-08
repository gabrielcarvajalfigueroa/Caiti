using Caiti.DbContexts;
using Caiti.DTOs;
using Caiti.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Services.ProfessorProviders
{
    public class DatabaseProfessorProvider : IProfessorProvider
    {
        private readonly CaitiDbContextFactory _dbContextFactory;
        public DatabaseProfessorProvider(CaitiDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<Professor>> GetAllProfessors()
        {
            using (CaitiDbContext context = _dbContextFactory.CreateDbContext())
            {
                await Task.Delay(3000);

                IEnumerable<ProfessorDTO> professorDTOs = await context.Professors.ToListAsync();

                return professorDTOs.Select(r => ToProfessor(r));
            }
        }

        private static Professor ToProfessor(ProfessorDTO dto)
        {
            return new Professor(dto.Name,dto.Email,dto.Phone,dto.Office_hours);
        }
    }
}
