using Caiti.DbContexts;
using Caiti.Models;
using Caiti.Services;
using Caiti.Services.ProfessorService;
using Caiti.Services.SubjectService;
using Caiti.Stores;
using Caiti.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Caiti
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string CONNECTION_STRING = "Data Source=caiti.db";

        private readonly SistemaProfesores _sistemaProfesores;
        private readonly NavigationStore _navigationStore;        
        private readonly CaitiDbContextFactory _caitiDbContextFactory;

        public App()
        {
            _caitiDbContextFactory = new CaitiDbContextFactory(CONNECTION_STRING);
            IProfessorControl professorControl = new ProfesorCreator(_caitiDbContextFactory);
            ISubjectControl subjectControl = new SubjectCreator(_caitiDbContextFactory);

            

            _sistemaProfesores = new SistemaProfesores(professorControl,subjectControl, "Sistema Caiti");
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(CONNECTION_STRING).Options;
            using(CaitiDbContext dbContext = new CaitiDbContext(options))
            {
                dbContext.Database.Migrate();
            }
            
            
            _navigationStore.CurrentViewModel = CreateInicioViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            MainWindow.Show();
            base.OnStartup(e);
        }


        private InicioViewModel CreateInicioViewModel()
        {
            return new InicioViewModel(_sistemaProfesores 
                                       ,new NavigationService(_navigationStore, CreateElegirCursoViewModel)
                                       ,new NavigationService(_navigationStore, CreateRegistroViewModel));
        }

        private RegistroViewModel CreateRegistroViewModel()
        {
            return new RegistroViewModel(_sistemaProfesores, new NavigationService(_navigationStore,CreateElegirCursoViewModel));
        }

        private ElegirCursoViewModel CreateElegirCursoViewModel()
        {
            return new ElegirCursoViewModel(_sistemaProfesores, new NavigationService(_navigationStore,CreateRegistroViewModel));
        }

    }
}
