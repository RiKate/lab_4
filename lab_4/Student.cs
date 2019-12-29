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
        public Dictionary<Subject, int> PassingLab { get; set; } = new Dictionary<Subject, int>();
        public Dictionary<Subject, List<Theme>> ListeningLections { get; set; } = new Dictionary<Subject, List<Theme>>();
        public Dictionary<Subject, List<Theme>> ListeningSeminars { get; set; } = new Dictionary<Subject, List<Theme>>();

        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();

        public void PassExam(Teacher teacher, Subject subject)
        {
            Console.WriteLine("Student " + FirstName + " " + LastName + " go to exam.");
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
                Console.WriteLine("Student " + FirstName + " " + LastName + "pass lab. Subject " + subj.Name + ". Count of passing labs = " + PassingLab[subj]);
            }
            else Console.WriteLine("Student " + FirstName + " " + LastName + " do not pass lab");
        }

        public void ListenLection(Subject subject, Theme theme)
        {
            if (ListeningLections != null && ListeningLections.ContainsKey(subject))
            {
                ListeningLections[subject].Add(theme);
            }
            else ListeningLections.Add(subject, new List<Theme>() { theme });
        }

        public void ListenSeminar(Subject subject, Theme theme)
        {
            if (ListeningSeminars != null && ListeningSeminars.ContainsKey(subject))
            {
                ListeningSeminars[subject].Add(theme);
            }
            else ListeningSeminars.Add(subject, new List<Theme>() { theme });
        }
    }
}
