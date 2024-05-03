
using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace StudiNotes
{
    public class School
    {
        private string lastName;

        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }

        public School()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
            Grades = new List<Grade>();
        }
        public void AddStudent(string firstName, string lastName, DateTime birthDate)
        {
            int id = Students.Count + 1;
            Student student = new Student(id, firstName, lastName, birthDate );
            Students.Add(student);
        }
        public void RemoveStudent(string firstName)
        {
            var student = Students.FirstOrDefault(s => s.FirstName == firstName);
            if (student != null)
            {
                Students.Remove(student);
            }
        }
        public List<Student> GetStudents()
        {
            return Students;
        }
        public Student GetStudent(string firstName)
        {
            return Students.FirstOrDefault(s => s.FirstName == firstName);
        }
        public void AddGrade(Student student, string course, double grade, string appreciation)
        {
            
            Grade newGrade = new Grade(student, course, grade, appreciation );
            Grades.Add(newGrade);
            Console.WriteLine($"{student.FirstName} a obtenu la note de {grade} au cours de {course} : {appreciation}");
        }
            public void HandleStudents()
        {
            while (true)
            {
                Console.WriteLine("Choisissez une option pour les élèves :");
                Console.WriteLine("1. Ajouter un élève");
                Console.WriteLine("2. Supprimer un élève");
                Console.WriteLine("3. Afficher tous les élèves");
                Console.WriteLine("4. Consulter un élève existant");
                Console.WriteLine("5. Ajouter une note et appréciation");
                Console.WriteLine("6. Retour");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Entrez le prénom de l'élève :");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Entrez le nom de l'élève :");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Entrez la date de naissance au format (AAAA-MM-DD) :");
                        DateTime BirthDate = DateTime.Parse(Console.ReadLine());
                        AddStudent(firstName, lastName, BirthDate);
                        Console.WriteLine($"L'élève {firstName} {lastName} a été ajouté.");
                        break;
                    case "2":
                        Console.WriteLine("Entrez le prénom de l'élève à supprimer :");
                        firstName = Console.ReadLine();
                        RemoveStudent(firstName);
                        Console.WriteLine($"L'élève {firstName} a été supprimé.");
                        break;
                    case "3":
                        Console.WriteLine("Voici tous les élèves :");
                        foreach (var newstudent in GetStudents())
                        {
                            Console.WriteLine($"{newstudent.FirstName} {newstudent.LastName}");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Entrez le prénom de l'élève à consulter :");
                        firstName = Console.ReadLine();
                        var student = GetStudent(firstName);
                        if (student != null)
                        {
                            Console.WriteLine($"Prénom: {student.FirstName}\nNom: {student.LastName}\nDate de naissance : {student.BirthDate}");
                        }
                        else
                        {
                            Console.WriteLine($"L'élève {firstName} n'existe pas.");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Entrez le prénom de l'élève à qui vous voulez ajouter une note :");
                        firstName = Console.ReadLine();
                        var studentToGrade = GetStudent(firstName);
                        if (studentToGrade != null)
                        {
                            Console.WriteLine("Entrez le cours pour lequel la note doit être ajoutée :");
                            string course = Console.ReadLine();
                            Console.WriteLine("Entrez la note de l'élève :");
                            double grade = double.Parse(Console.ReadLine());
                            Console.WriteLine("Voulez-vous ajouter une appréciation ? (y/n)");
                            string addAppreciation = Console.ReadLine();
                            string appreciation = "";
                            if (addAppreciation.ToLower() == "y")
                            {
                                Console.WriteLine("Entrez l'appréciation :");
                                appreciation = Console.ReadLine();
                            }
                            AddGrade(studentToGrade, course, grade, appreciation);
                            Console.WriteLine($"La note a été ajoutée à l'élève {firstName} pour le cours {course}.");
                        }
                        else
                        {
                            Console.WriteLine($"L'élève {firstName} n'existe pas.");
                        }
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Choix non valide. Veuillez réessayer.");
                        break;
                }
            }
        }
    
    public void AddCourse(string name)
        {
            var course = Courses.FirstOrDefault(c => c.Name == name);

            // Si le cours n'existe pas déjà, alors ajoutez-le.
            if (course == null)
            {
                int id = Courses.Count + 1;
                Course newCourse = new Course(id, name);
                Courses.Add(newCourse);
                Console.WriteLine($"Le cours {name} a été ajouté.");
            }
            else
            {
                Console.WriteLine("Le cours " + name + " existe déjà dans la liste.");
            }
        }
        public void RemoveCourse(string name)
        {
            var course = Courses.FirstOrDefault(c => c.Name == name);
            if (course != null)
            {
                Courses.Remove(course);
            }
        }
        public List<Course> GetCourses()
        {
            return Courses;
        }
        public void HandleCourses()
        {
            while (true)
            {
                Console.WriteLine("Choisissez une option pour les cours :");
                Console.WriteLine("1. Ajouter un cours");
                Console.WriteLine("2. Supprimer un cours");
                Console.WriteLine("3. Afficher tous les cours");
                Console.WriteLine("4. Retour");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Entrez le nom du cours :");
                        string nameW = Console.ReadLine();

                        AddCourse(nameW);

                        break;
                    case "2":
                        Console.WriteLine("Entrez le nom du cours à supprimer :");
                        string nameR = Console.ReadLine();
                        RemoveCourse(nameR);
                        Console.WriteLine($"Le cours  {nameR} a été supprimé.");
                        break;
                    case "3":
                        Console.WriteLine("Voici tous les cours :");
                        foreach (var course in GetCourses())
                        {
                            Console.WriteLine($"{course.Name}");
                        }
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Choix non valide. Veuillez réessayer.");
                        break;
                }
            }
        }
    }
}