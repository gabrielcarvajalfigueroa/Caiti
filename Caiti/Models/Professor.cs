﻿using System;
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
        
        public Professor(int id_professor, string name, string email, string phone, string office_hours)
        {
            Id_Professor = id_professor;
            Name = name;
            Email = email;
            Phone = phone;
            Office_hours = office_hours;

        }
        public int Id_Professor { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Office_hours { get; set; }
        public IEnumerable<Course> GetCoursesProfessor()
        {
            return _courses_professor;
        }
    }
}
