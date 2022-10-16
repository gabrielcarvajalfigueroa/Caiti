using Caiti.Models;
using Caiti.Services;
using Caiti.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Caiti.Commands
{
    public class RegistrarProfesorCommand : AsyncCommandBase
    {
        private readonly RegistroViewModel _registroViewModel;
        private readonly SistemaProfesores _sistemaProfesores;
        private readonly NavigationService _menuView;

        public RegistrarProfesorCommand(RegistroViewModel registroViewModel, 
            SistemaProfesores sistemaProfesores,
            NavigationService _menuViewNavigationService)
        {
            _registroViewModel = registroViewModel;
            _sistemaProfesores = sistemaProfesores;
            _menuView = _menuViewNavigationService;

        }

        public override async Task ExecuteAsync(object parameter)
        {
            Professor professor = new Professor(_registroViewModel.Nombre, _registroViewModel.Correo
                , _registroViewModel.Telefono, "Horas de oficina pendiente");

            
            try
            {
                await _sistemaProfesores.InsertProfessor(professor);
                MessageBox.Show("Profesor registrado con exito", "Success",
                    MessageBoxButton.OK, MessageBoxImage.Information);

                _sistemaProfesores._profesorEnSesion = professor;

                _menuView.Navigate();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problema al Insertar el Profesor", "Error",
                   MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
        
    }
}
