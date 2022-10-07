using Caiti.Clases_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Caiti.Views
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : UserControl
    {
        public List<Profesor> DatabaseProfesores { get; private set; }

        public Inicio()
        {
            InitializeComponent();
        }

        public bool VerificarProfesor()
        {
            using (DataContext context = new DataContext())
            {
                DatabaseProfesores = context.Profesores.ToList();

                var nombre_profesor = NombreProfesor.Text;

                foreach(Profesor profesor in DatabaseProfesores)
                {
                    if(profesor.Nombre == nombre_profesor)
                    {
                        return true;
                    }
                }
                return false;


            }

        }

        private void textChangedEventHandler(object sender, TextChangedEventArgs args)
        {
            if (VerificarProfesor())
            {
                ContinuarBoton.IsEnabled = true;
            }

        } 

        
    }
}
