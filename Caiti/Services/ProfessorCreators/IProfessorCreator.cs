using Caiti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Services.ProfessorCreators
{
    public interface IProfessorCreator
    {
        Task CreateProfessor(Professor professor);
    }
}
