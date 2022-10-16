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
    public class CursoViewModel : ViewModelBase
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

        public ICommand Volver { get; }

        public CursoViewModel(SistemaProfesores sistemaProfesores, NavigationService MenuViewNavigationService)
        {
            _nombreProfesor = sistemaProfesores._profesorEnSesion.Name;
            Volver = new NavigateCommand(MenuViewNavigationService);
        }
    }
}
