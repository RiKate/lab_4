using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4
{
    public class Subject
    {
        private List<Lection> lections;
        public string Name { get; set; }
        public ICollection<Lab> Labs { get; set; } = new List<Lab>();
        public ICollection<Lection> Lections { get { return lections; } set { lections = new List<Lection>(); } }
        public ICollection<Seminar> Seminars { get; set; } = new List<Seminar>();
    }
}
