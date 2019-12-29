using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4
{
    public class Institute
    {
        public string Name { get; set; }
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        public ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}
