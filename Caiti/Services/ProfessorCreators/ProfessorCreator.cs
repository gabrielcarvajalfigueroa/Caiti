using Caiti.DbContexts;
using Caiti.DTOs;
using Caiti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Services.ProfessorCreators
{
    public class ProfessorCreator : IProfessorCreator
    {
        private readonly CaitiDbContextFactory _dbContextFactory;
        public ProfessorCreator(CaitiDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task CreateProfessor(Professor professor)
        {
            using (CaitiDbContext context = _dbContextFactory.CreateDbContext())
            {
                await Task.Delay(3000);

                ProfessorDTO professorDTO = ToProfessorDTO(professor);

                context.Professors.Add(professorDTO);
                await context.SaveChangesAsync();
            }
        }

        private ProfessorDTO ToProfessorDTO(Professor professor)
        {
            return new ProfessorDTO()
            {
                Name= professor.Name,
                Email= professor.Email,
                Phone= professor.Phone,
                Office_hours= professor.Office_hours,
                
            };
        }
    }
}
