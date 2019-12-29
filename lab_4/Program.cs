using System;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Lab lab1 = new Lab();
            lab1.Name = "math_lab1";
            lab1.Variant = 5;

            Subject math = new Subject();
            math.SubjectID = 1;
            math.Name = "Math";
            math.Labs.Add(lab1);

            Subject informatics = new Subject();
            math.SubjectID = 2;
            math.Name = "informatics";

            Student student = new Student();
            student.FirstName = "Ivan";
            student.LastName = "Petrov";
            student.PhoneNumber = "+7777";
            student.Subjects.Add(math);
            student.Subjects.Add(informatics);

            Teacher teacher = new Teacher();
            teacher.FirstName = "Dmitry";
            teacher.LastName = "Ivanov";
            teacher.subject = math;

            teacher.TakeExam(student, informatics);
            student.PassExam(teacher, math);
                                  
            Console.WriteLine(student.PassLab(math, lab1));
            Console.WriteLine(student.PassLab(informatics, lab1));
        }
    }
}
