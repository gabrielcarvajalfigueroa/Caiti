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
        private readonly MenuViewModel _menuViewModel;
        private readonly SistemaProfesores _sistemaProfesores;
        private readonly NavigationService _menuView;
        

        public AgregarCursoCommand(MenuViewModel menuViewModel,
            SistemaProfesores sistemaProfesores,
            NavigationService menuView)
        {
            _menuViewModel = menuViewModel;
            _sistemaProfesores = sistemaProfesores;
            _menuView = menuView;
            
        }

        public override async Task ExecuteAsync(object parameter)
        {
            Subject subject = new Subject( _menuViewModel.NombreCurso, int.Parse(_menuViewModel.Creditos),true);

            
            try
            {
                await _sistemaProfesores.InsertSubject(subject, _sistemaProfesores._profesorEnSesion);
                MessageBox.Show("Curso ingresado con exito", "Success",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                _menuViewModel._subjectsProfeEnSesion.Add(subject);
                //_sistemaProfesores._profesorEnSesion.Subjects.Append<Subject>(subject);
                //Se debe convertir a list para poder agregar el subject
                List<Subject> lista = _sistemaProfesores._profesorEnSesion.Subjects.ToList();

                lista.Add(subject);

                _sistemaProfesores._profesorEnSesion.Subjects = lista;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema al Insertar el Profesor", "Error",
                   MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    
    }
}
