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

        public void GiveLection(Group group, Lection lection)
        {

        }

        public void GiveSeminar(Group group, Seminar seminar)
        {

        }
    }
}
