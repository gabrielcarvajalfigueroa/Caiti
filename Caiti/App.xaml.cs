using Caiti.DbContexts;
using Caiti.Models;
using Caiti.Services.ProfessorCreators;
using Caiti.Services.ProfessorProviders;
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
            IProfessorProvider professorProvider = new DatabaseProfessorProvider(_caitiDbContextFactory);
            IProfessorCreator professorCreator = new ProfessorCreator(_caitiDbContextFactory);

            ProfessorBook professorBook = new ProfessorBook(professorProvider, professorCreator);

            _sistemaProfesores = new SistemaProfesores(professorBook, "Sistema Caiti");
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(CONNECTION_STRING).Options;
            using(CaitiDbContext dbContext = new CaitiDbContext(options))
            {
                dbContext.Database.Migrate();
            }
            
            
            _navigationStore.CurrentViewModel = new RegistroViewModel(_navigationStore,_sistemaProfesores);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            MainWindow.Show();
            base.OnStartup(e);
        }

    }
}
