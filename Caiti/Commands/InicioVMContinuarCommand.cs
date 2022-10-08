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
    public class InicioVMContinuarCommand : AsyncCommandBase
    {
        private readonly InicioViewModel _inicioViewModel;
        private readonly SistemaProfesores _sistemaProfesores;
        private readonly NavigationService _elegirCursoViewNavigationService;

        private bool _existProfessor = false;

        public InicioVMContinuarCommand(InicioViewModel inicioViewModel, 
            SistemaProfesores sistemaProfesores, 
            NavigationService elegirCursoViewNavigationService)
        {
            _inicioViewModel = inicioViewModel;
            _sistemaProfesores = sistemaProfesores;
            _elegirCursoViewNavigationService = elegirCursoViewNavigationService;
        }

        public override async Task ExecuteAsync(object parameter)
        {


            try
            {
                IEnumerable<Professor> professors = await _sistemaProfesores.GetAllProfessors();

                foreach (Professor professor in professors)
                {
                    if (professor.Name == _inicioViewModel.NombreUsuario)
                    {
                        _elegirCursoViewNavigationService.Navigate();
                        _existProfessor = true;
                    }
                }


                if (!_existProfessor)
                {
                    MessageBox.Show("El profesor no se encuentra Registrado", "Registrar Usuario",
                   MessageBoxButton.OK, MessageBoxImage.Information);
                }
               

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema al Buscar el Profesor", "Error",
                   MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
