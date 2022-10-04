using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Models
{
    public class Course
    {
        public Course(string id_course, string code, string nrc, int semester, int year, string course_purpose)
        {
            Id_Course = id_course;
            Code = code;
            Nrc = nrc;
            Semester = semester;
            Year = year;
            Course_Purpose = course_purpose;
        }
        public string Id_Course { get; set; }
        public string Code { get; set; }
        public string Nrc { get; set; }
        public int Semester { get; set; }
        public int Year { get; set; }
        public string Course_Purpose { get; set; }
        public Boolean Conflicts(Course course)
        {
            if(course.Code != Code && course.Nrc != Nrc)
            {
                return false;
            }
            return course.Semester==Semester && course.Year==Year;

        }
    }

}
