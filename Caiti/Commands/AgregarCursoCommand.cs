using Caiti.Models;
using Caiti.Services;
using Caiti.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Caiti.Commands
{
    public class AgregarCursoCommand : AsyncCommandBase
    {
        private readonly ElegirCursoViewModel _elegirCursoViewModel;
        private readonly SistemaProfesores _sistemaProfesores;
        private readonly NavigationService _elegirCursoViewNavigationService;

        public AgregarCursoCommand(ElegirCursoViewModel elegirCursoViewModel,
            SistemaProfesores sistemaProfesores,
            NavigationService elegirCursoViewNavigationService)
        {
            _elegirCursoViewModel = elegirCursoViewModel;
            _sistemaProfesores = sistemaProfesores;
            _elegirCursoViewNavigationService = elegirCursoViewNavigationService;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            Subject subject = new Subject( _elegirCursoViewModel.Ramo, _elegirCursoViewModel.Creditos,true);

            
            try
            {
                await _sistemaProfesores.InsertSubject(subject, _sistemaProfesores._profesorEnSesion);
                MessageBox.Show("Curso ingresado con exito", "Success",
                    MessageBoxButton.OK, MessageBoxImage.Information);

                //_elegirCursoViewNavigationService.Navigate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema al Insertar el Profesor", "Error",
                   MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    
    }
}
