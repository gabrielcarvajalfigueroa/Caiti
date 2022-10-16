using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Models
{
    public class Professor
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Office_hours { get; set; }

        public IEnumerable<Subject> Subjects { get; set; }

        public Professor(string name, string email, string phone, string office_hours)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Office_hours = office_hours;

        }
    }
}
