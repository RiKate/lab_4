using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4
{
    public class Subject
    {
        public string Name { get; set; }
        public ICollection<Lab> Labs { get; set; } = new List<Lab>();
        public ICollection<Lection> Lections { get; set; } = new List<Lection>();
        public ICollection<Seminar> Seminars { get; set; } = new List<Seminar>();
    }
}
