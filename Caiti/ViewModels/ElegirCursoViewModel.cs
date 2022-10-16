using Caiti.Commands;
using Caiti.Models;
using Caiti.Services;
using Caiti.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Caiti.ViewModels
{
    public class ElegirCursoViewModel : ViewModelBase
    {

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

        private string _ramo;

        public string Ramo
        {
            get
            {
                return _ramo;
            }
            set
            {
                _ramo = value;
                OnPropertyChanged(nameof(Ramo));
            }
        }

        private int _creditos;

        public int Creditos
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

        public ICommand AgregarCommand { get; }

        public ICommand EditarRACommand { get; }

        public ElegirCursoViewModel(SistemaProfesores sistemaProfesores, NavigationService elegirCursoViewNavigationService)
        {
            // se implementa haciendo uso del navigate command
            //AgregarCommand = new AgregarCursoCommand(this, sistemaProfesores, elegirCursoViewNavigationService);
            _subjectsProfeEnSesion = sistemaProfesores._profesorEnSesion.Subjects;
            EditarRACommand = new EditarRACommand();
        }

       
    }
}
