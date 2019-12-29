using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4
{
    public class Group
    {
        private int count;
        public string Name { get; set; }
        public int CountOfStudents { set { count = Students.Count; } get { return count; } }
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
