using Caiti.DbContexts;
using Caiti.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Services.SubjectService
{
    public class SubjectCreator : ISubjectControl
    {
        private readonly CaitiDbContextFactory _dbContextFactory;

        public SubjectCreator(CaitiDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task CreateSubject(Subject subject, Professor professor)
        {
            using (CaitiDbContext context = _dbContextFactory.CreateDbContext())
            {
                await Task.Delay(3000);

                subject.ProfessorID = professor.Id;
                context.Subjects.Add(subject);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Subject>> GetAllSubjects(Professor professor)
        {
            using (CaitiDbContext context = _dbContextFactory.CreateDbContext())
            {
                await Task.Delay(3000);

                IEnumerable<Subject> subjects = await context.Subjects.ToListAsync(); ;


                return subjects.Where(s => s.ProfessorID == professor.Id);
            }
        }
    }
}
