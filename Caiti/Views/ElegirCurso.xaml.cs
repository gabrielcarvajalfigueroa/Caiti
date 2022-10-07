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
    /// Lógica de interacción para ElegirCurso.xaml
    /// </summary>
    public partial class ElegirCurso : UserControl
    {
        public List<Curso> DatabaseCursos { get; private set; }
        public ElegirCurso()
        {
            InitializeComponent();
            Leer_BD();
        }

        public void Crear_Curso()
        {
            

            using (DataContext context = new DataContext())
            {
                var nombre_curso = NombreCurso.Text;
                

                if (nombre_curso != null)
                {
                    context.Cursos.Add(new Curso()
                    {
                        Nombre_curso = nombre_curso,
                        
                    });
                    context.SaveChanges();
                }

            }
        }

        public void Leer_BD()
        {
            using (DataContext context = new DataContext())
            {
                DatabaseCursos = context.Cursos.ToList();
                CursosList.ItemsSource = DatabaseCursos;
            }

        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            Crear_Curso();
            Leer_BD();
        }
    }
}
