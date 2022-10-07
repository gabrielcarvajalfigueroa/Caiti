using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Clases_BD
{
    public class Curso
    {
        [Key]
        public int Id_curso { get; set; }

        public string Nombre_curso { get; set; }

        
    }
}
