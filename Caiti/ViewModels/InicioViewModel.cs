using Caiti.Commands;
using Caiti.Models;
using Caiti.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Caiti.ViewModels
{
    public class InicioViewModel : ViewModelBase
    {
        private string _nombreUsuario;

        public string NombreUsuario
        {
            get
            {
                return _nombreUsuario;
            }
            set
            {
                _nombreUsuario = value;
                OnPropertyChanged(nameof(NombreUsuario));
            }
        }

        public ICommand RegistrarseCommand { get; }

        public ICommand ContinuarCommand { get; }
        
        public InicioViewModel(NavigationStore navigationStore, SistemaProfesores sistemaProfesores)
        {
            //RegistrarseCommand = new NavigateCommand<RegistroViewModel>(navigationStore, () => new RegistroViewModel(navigationStore));
            
        }
        
    }
}
