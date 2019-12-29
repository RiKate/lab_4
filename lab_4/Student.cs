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
        public Dictionary<Subject, List<Theme>> ListeningLections { get; set; }
        public Dictionary<Subject, List<Theme>> ListeningSeminars { get; set; }

        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();

        public void PassExam(Teacher teacher, Subject subject)
        {
            if(teacher.CheckLabs(this, subject))
            {
                Theme theme = teacher.GiveQuestion();
                if (ListeningLections[subject].Contains(theme))
                    teacher.TakeExam();
                else
                    Console.WriteLine("Fail");
            }
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
            }
        }

        public void ListenLection(Subject subject, Theme theme)
        {
            if (ListeningLections.ContainsKey(subject))
            {
                ListeningLections[subject].Add(theme);
            }
            ListeningLections.Add(subject, new List<Theme>() { theme });
        }

        public void ListenSeminar(Subject subject, Theme theme)
        {
            if (ListeningSeminars.ContainsKey(subject))
            {
                ListeningSeminars[subject].Add(theme);
            }
            ListeningSeminars.Add(subject, new List<Theme>() { theme });
        }
    }
}
