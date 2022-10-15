using Caiti.Models;
using Caiti.Stores;
using Caiti.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Services
{
    public class NavigationService
    {
        public NavigationStore _navigationStore;
        public  Func<ViewModelBase> _createViewModel;

        public Professor _professorEnSesion { get;  set; } 

        public NavigationService(NavigationStore navigationStore, Func<ViewModelBase> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
