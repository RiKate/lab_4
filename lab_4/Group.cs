using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4
{
    public class Group
    {
        public string Name { get; set; }
        public int CountOfStudents { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
