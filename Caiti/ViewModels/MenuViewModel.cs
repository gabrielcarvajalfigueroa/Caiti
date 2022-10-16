using Caiti.Commands;
using Caiti.Models;
using Caiti.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Caiti.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        private string _nombreProfesor; // Nombre del profesor que esta en sesion

        public string NombreProfesor
        {
            get
            {
                return _nombreProfesor;
            }
            set
            {
                _nombreProfesor = value;
                OnPropertyChanged(nameof(NombreProfesor));
            }
        }

        public IEnumerable<Subject> _subjectsProfeEnSesion;


        public IEnumerable<Subject> SubjectsProfeEnSesion
        {
            get
            {
                return _subjectsProfeEnSesion;
            }
            set
            {
                _subjectsProfeEnSesion = value;
                OnPropertyChanged(nameof(SubjectsProfeEnSesion));
            }
        }

        public ICommand EditarCurso { get; }

        public ICommand Volver { get; }

        public MenuViewModel(SistemaProfesores sistemaProfesores, NavigationService CursoView, NavigationService InicioView)
        {
            _nombreProfesor = sistemaProfesores._profesorEnSesion.Name;
            _subjectsProfeEnSesion = sistemaProfesores._profesorEnSesion.Subjects;

            EditarCurso = new NavigateCommand(CursoView);
            Volver = new NavigateCommand(InicioView);
        }
    }
}
