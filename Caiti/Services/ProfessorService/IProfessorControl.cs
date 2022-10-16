using Caiti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Services.ProfessorService
{
    public interface IProfessorControl
    {
        Task CreateProfessor(Professor professor);

        Task<IEnumerable<Professor>> GetAllProfessors();
    }
}
