using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Models
{
    public class Professor
    {
        private readonly List<Course> _courses_professor;
        
        public Professor(string name, string email, string phone, string office_hours)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Office_hours = office_hours;

        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Office_hours { get; set; }
        public IEnumerable<Course> GetCoursesProfessor()
        {
            return _courses_professor;
        }

        public void AddCourse(Course course)
        {
            foreach (Course existingCourse in _courses_professor)
            {
                if (existingCourse.Conflicts(course))
                {
                    throw new CourseConflictException(existingCourse, course);
                }
            }
            _courses_professor.Add(course);
        }
    }
}
