using Caiti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Services.ProfessorProviders
{
    public interface IProfessorProvider
    {
        Task<IEnumerable<Professor>> GetAllProfessors();
    }
}
