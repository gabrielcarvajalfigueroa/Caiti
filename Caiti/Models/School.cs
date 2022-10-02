using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caiti.Models
{
    public class School
    {
        private readonly List<Career> _careers;
        public School(string id_school, string name)
        {
            Id_School = id_school;
            Name = name;
            _careers = new List<Career>();
        }
        public string Id_School { get; set; }
        public string Name { get; set; }
        public IEnumerable<Career> GetCareersForSchool()
        {
            return _careers;
        }


    }
}
