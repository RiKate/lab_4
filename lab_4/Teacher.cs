using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject subject;

        public void TakeExam(Student s, Subject subj)
        {
            if (subj != subject)
                Console.WriteLine(FirstName + " " + LastName + " do not take an exam");
            else
                Console.WriteLine(FirstName + " " + LastName + " take an exam");
        }

        public bool TakeLab(Subject subj, Lab lab)
        {
            if (subject.Name == subj.Name)
            {
                foreach(var l in subject.Labs)
                {
                    if (l.Variant == lab.Variant && l.Name == lab.Name)
                        return true;
                }
            }
            return false;
        }

        public void GiveLection(List<Student> students, Group group, Lection lection)
        {
            foreach(var student in students)
            {
                if (group.Students.Contains(student))
                {
                    student.ListenLection(subject, lection.Theme);
                }
            }
        }

        public void GiveSeminar(List<Student> students, Group group, Seminar seminar)
        {
            foreach (var student in students)
            {
                if (group.Students.Contains(student))
                {
                    student.ListenSeminar(subject, seminar.Theme);
                }
            }
        }


    }
}
