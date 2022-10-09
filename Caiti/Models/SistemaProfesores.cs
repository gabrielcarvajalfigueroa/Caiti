using Caiti.Services.ProfessorService;
using Caiti.Services.SubjectService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Models
{
    public class SistemaProfesores
    {
        private readonly IProfessorControl _professorControl;
        private readonly ISubjectControl _subjectControl;

        public string _nombreSistema;

        public Professor _profesorEnSesion { get; set; }

        public SistemaProfesores(IProfessorControl professorControl,ISubjectControl subjectControl,string nombreSistema)
        {
            _professorControl = professorControl;
            _subjectControl = subjectControl;
            _nombreSistema = nombreSistema;
            
        }

        public async Task<IEnumerable<Professor>> GetAllProfessors()
        {
            return await _professorControl.GetAllProfessors();
        }

        public async Task InsertProfessor(Professor professor)
        {
            await _professorControl.CreateProfessor(professor);
        }

        
        public async Task InsertSubject(Subject subject, Professor professor)
        {
            await _subjectControl.CreateSubject(subject, professor);
        }
        public async Task<IEnumerable<Subject>> GetAllSubjects(Professor professor)
        {
            return await _subjectControl.GetAllSubjects(professor);
        }
    }
}
