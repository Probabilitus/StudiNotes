namespace StudiNotes
{
    public class School
    {
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public School()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
        }
        public void AddStudent(string firstName)
        {
            int id = Students.Count + 1;
            Student student = new Student(id, firstName);
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
        public void HandleStudents()
        {
            while (true)
            {
                Console.WriteLine("Choisissez une option pour les élèves :");
                Console.WriteLine("1. Ajouter un élève");
                Console.WriteLine("2. Supprimer un élève");
                Console.WriteLine("3. Afficher tous les élèves");
                Console.WriteLine("4. Retour");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Entrez le prénom de l'élève :");
                        string firstName = Console.ReadLine();

                        AddStudent(firstName);
                        Console.WriteLine($"L'élève {firstName} a été ajouté.");
                        break;
                    case "2":
                        Console.WriteLine("Entrez le prénom de l'élève à supprimer :");
                        firstName = Console.ReadLine();
                        RemoveStudent(firstName);
                        Console.WriteLine($"L'élève {firstName} a été supprimé.");
                        break;
                    case "3":
                        Console.WriteLine("Voici tous les élèves :");
                        foreach (var student in GetStudents())
                        {
                            Console.WriteLine($"{student.FirstName} {student.LastName}");
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