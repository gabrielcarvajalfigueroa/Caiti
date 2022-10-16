using Caiti.Commands;
using Caiti.Models;
using Caiti.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public ObservableCollection<Subject> _subjectsProfeEnSesion;


        public ObservableCollection<Subject> SubjectsProfeEnSesion
        {
            get
            {
                return _subjectsProfeEnSesion;
            }
            
        }

        private string _nombreCurso;

        public string NombreCurso
        {
            get
            {
                return _nombreCurso;
            }
            set
            {
                _nombreCurso = value;
                OnPropertyChanged(nameof(NombreCurso));
            }
        }

        private string _creditos;

        public string Creditos
        {
            get
            {
                return _creditos;
            }
            set
            {
                _creditos = value;
                OnPropertyChanged(nameof(Creditos));
            }
        }

        public ICommand EditarCurso { get; }

        public ICommand Aceptar { get; }

        public ICommand Volver { get; }

        public MenuViewModel(SistemaProfesores sistemaProfesores, NavigationService CursoView, NavigationService InicioView, NavigationService MenuView)
        {
            _nombreProfesor = sistemaProfesores._profesorEnSesion.Name;
            
            _subjectsProfeEnSesion = new ObservableCollection<Subject>(sistemaProfesores._profesorEnSesion.Subjects);

            Aceptar = new AgregarCursoCommand(this, sistemaProfesores,MenuView);

            EditarCurso = new NavigateCommand(CursoView);
            Volver = new NavigateCommand(InicioView);
            
        }

        public void AgregarCurso(Subject subject)
        {
            _subjectsProfeEnSesion.Append<Subject>(subject);
        }
    }
}
