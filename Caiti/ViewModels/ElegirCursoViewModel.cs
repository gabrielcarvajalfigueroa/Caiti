using Caiti.Commands;
using Caiti.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Caiti.ViewModels
{
    public class ElegirCursoViewModel : ViewModelBase
    {
        // Pendiente Hacer el data binding
        public ICommand PlanificarCommand { get; }

        public ElegirCursoViewModel(NavigationStore navigationStore)
        {
            PlanificarCommand = new NavigateCommand<PlanificacionViewModel>(navigationStore, () => new PlanificacionViewModel(navigationStore));

        }
        
    }
}
