using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Dictionary<Subject, int> PassingLab { get; set; }
        public Dictionary<Subject, Theme> ListeningLections { get; set; }
        public Dictionary<Subject, Theme> ListeningSeminars { get; set; }

        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();


        public void PassExam(Teacher t, Subject s)
        {
            if (t.subject == s)
                Console.WriteLine(FirstName + " " + LastName + " pass the exam " + s.Name);
            else
                Console.WriteLine(FirstName + " " + LastName + " do not pass the exam " + s.Name);
        }

        public void PassLab(Teacher teacher, Subject subj, Lab passingLab)
        {
            if (teacher.TakeLab(subj, passingLab))
            {
                if (PassingLab.ContainsKey(subj))
                {
                    PassingLab[subj] = PassingLab[subj]++;
                }
                else
                {
                    PassingLab.Add(subj, 1);
                }
            }s
        }

        public void ListenLection(Subject subject, Theme theme)
        {
            ListeningLections.Add(subject, theme);
        }

        public void ListenSeminar(Subject subject, Theme theme)
        {
            ListeningSeminars.Add(subject, theme);
        }
    }
}
