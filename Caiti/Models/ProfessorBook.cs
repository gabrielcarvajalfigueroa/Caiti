using Caiti.Services.ProfessorCreators;
using Caiti.Services.ProfessorProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Models
{
    public class ProfessorBook
    {
        private readonly IProfessorProvider _professorProvider;
        private readonly IProfessorCreator _professorCreator;

        public ProfessorBook(IProfessorProvider professorProvider, IProfessorCreator professorCreator)
        {
            _professorProvider = professorProvider;
            _professorCreator = professorCreator;
        }

        public async Task<IEnumerable<Professor>> GetAllProfessors()
        {
            return await _professorProvider.GetAllProfessors();
        }

        public async Task AddProfessor(Professor professor)
        {
            // Puede que falte el tema de los conflictos

            await _professorCreator.CreateProfessor(professor);

        }
    }
}
