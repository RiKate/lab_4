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

        public bool CheckLabs(Student student, Subject subj)
        {
            if (!student.PassingLab.ContainsKey(subj) || student.PassingLab[subj] != subj.Labs.Count)
            {
                Console.WriteLine("Student " + FirstName + " " + LastName + " can not pass the exam. Labs dont pass.");
                return false;
            }
            return true;
        }

        public Theme GiveQuestion()
        {
            var rand = new Random();
            int question = rand.Next(0, subject.Lections.Count);
            Console.WriteLine("Teacher give question with theme: " + ((List<Lection>)subject.Lections)[question].Theme.Name);
            return ((List<Lection>)subject.Lections)[question].Theme;
        }

        public bool TakeExam()
        {
            Console.WriteLine("Success");
            return true;
        }

        public bool TakeLab(Subject subj, Lab lab)
        {
            if (subject == subj)
            {
                foreach (var l in subject.Labs)
                {
                    if (l.Variant == lab.Variant && l.Name == lab.Name)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void GiveLection(List<Student> students, Group group, Lection lection)
        {
            foreach (var student in students)
            {
                if (group.Students.Contains(student))
                {
                    student.ListenLection(subject, lection.Theme);
                    Console.WriteLine("Student " + student.FirstName + " " + LastName + " listen lection with theme: " + lection.Theme.Name);
                }
                else
                    Console.WriteLine("Student " + student.FirstName + " " + LastName + " remove from class");
            }
        }

        public void GiveSeminar(List<Student> students, Group group, Seminar seminar)
        {
            foreach (var student in students)
            {
                if (group.Students.Contains(student))
                {
                    student.ListenSeminar(subject, seminar.Theme);
                    Console.WriteLine("Student " + student.FirstName + " " + LastName + " listen seminar with theme: " + seminar.Theme.Name);
                }
                else
                    Console.WriteLine("Student " + student.FirstName + " " + LastName + " remove from class");
            }
        }


    }
}
