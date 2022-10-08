using Caiti.Commands;
using Caiti.Models;
using Caiti.Services;
using Caiti.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace Caiti.ViewModels
{
    public class RegistroViewModel : ViewModelBase
    {
        private string _nombre;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }

        private string _apellido;

        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
                OnPropertyChanged(nameof(Apellido));
            }
        }

        private string _correo;

        public string Correo
        {
            get
            {
                return _correo;
            }
            set
            {
                _correo = value;
                OnPropertyChanged(nameof(Correo));
            }
        }

        private string _telefono;

        public string Telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                _telefono = value;
                OnPropertyChanged(nameof(Telefono));
            }
        }

        public ICommand ListoCommand { get; }

        public RegistroViewModel(SistemaProfesores sistemaProfesores, NavigationService elegirCursoViewNavigationService)
        {
            // se implementa haciendo uso del navigate command
            //ListoCommand = new NavigateCommand<ElegirCursoViewModel>(navigationStore, () => new ElegirCursoViewModel(navigationStore));
            ListoCommand = new RegistrarProfesorCommand(this, sistemaProfesores, elegirCursoViewNavigationService);        
        }

    }
}
