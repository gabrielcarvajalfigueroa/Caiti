using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Models
{
    public class SistemaProfesores
    {
        private readonly ProfessorBook _professorBook;

        public string _nombreSistema;

        public SistemaProfesores(ProfessorBook professorBook, string nombreSistema)
        {
            _professorBook = professorBook;
            _nombreSistema = nombreSistema;
        }

        public async Task<IEnumerable<Professor>> GetAllProfessors()
        {
            return await _professorBook.GetAllProfessors();
        }

        public async Task InsertProfessor(Professor professor)
        {
            await _professorBook.AddProfessor(professor);
        }
    }
}
