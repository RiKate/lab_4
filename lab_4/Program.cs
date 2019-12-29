using System;
using System.Collections.Generic;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Labs*/
            Lab lab = new Lab();
            lab.Name = "Math";
            lab.Variant = 5;

            /*Theme*/
            Theme themeMath1 = new Theme();
            themeMath1.Name = "Theme1";
            Theme themeMath2 = new Theme();
            themeMath2.Name = "Theme2";

            /*Lections*/
            Lection lection1 = new Lection();
            lection1.Theme = themeMath1;

            Lection lection2 = new Lection();
            lection2.Theme = themeMath2;

            Seminar seminar = new Seminar();
            seminar.Theme = themeMath1;

            /*Subjects*/
            Subject math = new Subject();
            math.Name = "Math";
            math.Lections.Add(lection1);
            math.Lections.Add(lection2);
            math.Seminars.Add(seminar);
            math.Labs.Add(lab);

            Subject informatics = new Subject();
            math.Name = "informatics";
        
            /*Students*/
            Student student1 = new Student();
            student1.FirstName = "Ivan";
            student1.LastName = "Petrov";
            student1.PhoneNumber = "+7777";
            student1.Subjects.Add(math);
            student1.Subjects.Add(informatics);

            Student student2 = new Student();
            student2.FirstName = "Alexander";
            student2.LastName = "Ivanov";
            student2.PhoneNumber = "+8888";
            student2.Subjects.Add(math);
            student2.Subjects.Add(informatics);

            Student student3 = new Student();
            student3.FirstName = "Yury";
            student3.LastName = "Silin";
            student3.PhoneNumber = "+99999";
            student3.Subjects.Add(math);
            student3.Subjects.Add(informatics);

            /*Group*/
            Group group = new Group();
            group.Students.Add(student1);
            group.Students.Add(student2);

            Teacher teacher = new Teacher();
            teacher.FirstName = "Dmitry";
            teacher.LastName = "Ivanov";
            teacher.subject = math;

            teacher.GiveLection(new List<Student>() { student1, student3 }, group, lection1);
            teacher.GiveLection(new List<Student>() { student1, student2 }, group, lection2);

            teacher.GiveSeminar(new List<Student>() { student1, student2, student3 }, group, seminar);

            student1.PassLab(teacher, math, lab);
            student2.PassLab(teacher, math, lab);
            student3.PassLab(teacher, informatics, lab);

            student1.PassExam(teacher, math);
            student2.PassExam(teacher, math);
            student3.PassExam(teacher, math);
        }
    }
}
