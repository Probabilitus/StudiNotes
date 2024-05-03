using StudiNotes;
using System.Diagnostics;

public class Grade
{
    Student Student { get; set; }
    string Course { get; set; }
    double GradeValue { get; set; }
    string  Appreciation { get; set; }

     public Grade(Student student, string course, double grade, string appreciation)
     {
        Student = student;
        Course = course;
        GradeValue = grade;
        Appreciation = appreciation;
     }
}

