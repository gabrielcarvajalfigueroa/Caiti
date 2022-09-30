using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para Planificacion.xaml
    /// </summary>
    /// 


    public class Clase
    {

        public Clase()
        {
            this.tipoClases = new string[] { "Catedra", "Ayudantia", "Prueba" };
        }

        public string idClase { get; set; }

        public string comentario { get; set; }

        public bool realizada { get; set; }

        public string[] tipoClases { get; set; }


    }
    public class Semana
    {
        public List<Clase> Clases { get; set; }
        public string idSemana { get; set; }

        public ArrayList info { get; set; } // contiene id de la semana y un boton


        public Semana(string id)
        {
            Button btn = new Button();

            btn.Content = "+";
            btn.Name = "agregarSemana";
            btn.Click += Planificacion.AgregarSemana_Click;

            info = new ArrayList();

            info.Add("S" + id);
            info.Add(btn);

        }
    }
    public partial class Planificacion : UserControl
    {
        public ObservableCollection<Semana> listaSemanas { get; set; }

        public DataGrid dg { get; set; }


        public Planificacion()
        {

            InitializeComponent();

            

            listaSemanas = new ObservableCollection<Semana>
        {
        new Semana("1") {
            Clases = new List<Clase> {
                new Clase { idClase = "C1", comentario = "" , realizada=false},
                new Clase { idClase = "C2", comentario = "" , realizada=false},
            },
            idSemana = "S1" },
        new Semana("2") {
            Clases = new List<Clase> {
                new Clase { idClase = "C1", comentario = "" , realizada=false},
                new Clase { idClase = "C2", comentario = "" , realizada=false},
                new Clase { idClase = "C3", comentario = "" , realizada=false},
            },
            idSemana = "S2" },
        new Semana("3") {
            Clases = new List<Clase> {
                new Clase { idClase = "C1", comentario = "" , realizada=false},
                new Clase { idClase = "C2", comentario = "" , realizada=false},
                new Clase { idClase = "C3", comentario = "" , realizada=false},
            },
            idSemana = "S3" },
    };



            dataGrid1.ItemsSource = listaSemanas;
        }
        public static void AgregarSemana_Click(object sender, RoutedEventArgs e)
        {
            
            
            //dataGrid1.Items.Add(new Semana("5"));
        }
    }
}
