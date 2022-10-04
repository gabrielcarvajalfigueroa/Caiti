using System.Collections.Generic;
using System.Windows.Documents;

namespace Caiti.Models
{
    public class Career
    {
        private readonly List<Subject> _subjects;
        public Career(string id_career, string name_career)
        {
            Id_Career = id_career;
            Name_Career = name_career;
        }

        public string Id_Career { get; set; }
        public string Name_Career { get; set; }
        public IEnumerable<Subject> GetSubjects()
        {
            return _subjects;
        }
    }
}