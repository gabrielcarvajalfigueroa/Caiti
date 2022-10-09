using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace Caiti.Models
{
    public class Subject
    {
        public Subject(string name_Subject, int credits, bool obligatory)
        {
            Name_Subject = name_Subject;
            Credits = credits;
            Obligatory = obligatory;
        }

        [Key]
        public Guid Id_Subject { get; set; }

        [ForeignKey("Professor")]
        public Guid ProfessorID { get; set; }

        public string Name_Subject { get; set; }
        public int Credits { get; set; }
        public bool Obligatory { get; set; }

      
    }
}
