namespace StudiNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            while (true)
            {
                Console.WriteLine("Choisissez une option :");
                Console.WriteLine("1. Élèves");
                Console.WriteLine("2. Cours");
                Console.WriteLine("3. Quitter");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        school.HandleStudents();
                        break;
                    case "2":
                        school.HandleCourses();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Choix non valide. Veuillez réessayer.");
                        break;
                }
            }
        }
    }
}
