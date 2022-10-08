using Caiti.Services.ProfessorCreators;
using Caiti.Services.ProfessorProviders;
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
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Office_hours { get; set; }
      
        public Professor(string name, string email, string phone, string office_hours)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Office_hours = office_hours;

        }

    }
}
