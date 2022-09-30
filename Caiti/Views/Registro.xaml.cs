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
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : UserControl
    {
        public List<Profesor> DatabaseProfesores { get; private set; }
        public Registro()
        {
            InitializeComponent();
        }

        public void Create()
        {

            using (DataContext context = new DataContext())
            {
                var nombre = Nombre.Text;
                var apellido = Apellido.Text;
                var correo = Correo.Text;
                var telefono = Telefono.Text;

                if (nombre != null && apellido != null)
                {
                    context.Profesores.Add(new Profesor()
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        Correo = correo,
                        Telefono = telefono
                    });
                    context.SaveChanges();
                }

            }
        }

        public void Read()
        {
            using (DataContext context = new DataContext())
            {
                DatabaseProfesores = context.Profesores.ToList();
                Console.WriteLine(DatabaseProfesores[0].Nombre);
                Console.WriteLine(DatabaseProfesores[1].Nombre);
                
            }

        }

        public void Listo_Click(object sender, RoutedEventArgs e)
        {
            Create();
            Read();

        }
    }
}
