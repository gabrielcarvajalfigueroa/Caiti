using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Models
{
    public class Course
    {
        public Course(string id_course, string code, string nrc, int semester, string course_purpose)
        {
            Id_Course = id_course;
            Code = code;
            Nrc = nrc;
            Semester = semester;
            Course_Purpose = course_purpose;
        }

        public string Id_Course { get; set; }
        public string Code { get; set; }
        public string Nrc { get; set; }
        public int Semester { get; set; }
        public string Course_Purpose { get; set; }
    }

}
