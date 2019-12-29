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
        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();


        public void PassExam(Teacher t, Subject s)
        {
            if (t.subject == s)
                Console.WriteLine(FirstName + " " + LastName + " pass the exam " + s.Name);
            else
                Console.WriteLine(FirstName + " " + LastName + " do not pass the exam " + s.Name);
        }

        public bool PassLab(Subject subj, Lab passingLab)
        {
            foreach(var subject in Subjects)
            {
                if(subject == subj)
                {
                    foreach(var lab in subject.Labs)
                    {
                        if (lab.Name == passingLab.Name && lab.Variant == passingLab.Variant)
                            return true;
                    }
                }
            }
            return false;
        }

        public void ListenLection()
        {

        }

        public void ListenSeminar()
        {

        }
    }
}
