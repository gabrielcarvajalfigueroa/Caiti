using Caiti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Services.SubjectService
{
    public interface ISubjectControl
    {
        Task CreateSubject(Subject subject, Professor professor);

        Task<IEnumerable<Subject>> GetAllSubjects(Professor professor);
    }
}
