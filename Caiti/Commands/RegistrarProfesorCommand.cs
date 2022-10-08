using Caiti.Models;
using Caiti.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace Caiti.Commands
{
    public class RegistrarProfesorCommand : AsyncCommandBase
    {
        private readonly RegistroViewModel _registroViewModel;
        private readonly SistemaProfesores _sistemaProfesores;
        //private readonly NavigationService _elegirCursoViewNavigationService;

        public RegistrarProfesorCommand(RegistroViewModel registroViewModel, 
            SistemaProfesores sistemaProfesores)
        {
            _registroViewModel = registroViewModel;
            _sistemaProfesores = sistemaProfesores;
            //_elegirCursoViewNavigationService = elegirCursoViewNavigationService;

        }

        public override async Task ExecuteAsync(object parameter)
        {
            Professor professor = new Professor(_registroViewModel.Nombre, _registroViewModel.Correo
                , _registroViewModel.Telefono, "Horas de oficina pendiente");

            
            try
            {
                await _sistemaProfesores.InsertProfessor(professor);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problema al Insertar el Profesor", "Error",
                   MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
        
    }
}
