using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace Caiti.Models
{
    public class Subject
    {
        private readonly List<Course> _courses;
        public Subject(string id_subject, string name_subject, int credits, Boolean obligatory)
        {
            Id_Subject = id_subject;
            Name_Subject = name_subject;
            Credits = credits;
            Obligatory = obligatory;
        }
        public string Id_Subject { get; set; }
        public string Name_Subject { get; set; }
        public int Credits { get; set; }
        public bool Obligatory { get; set; }
        public IEnumerable<Course> GetCourses()
        {
            return _courses;
        }
    }
}
