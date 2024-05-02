namespace StudiNotes
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public Student(int id)
        {
            Id = id;
        }
        public Student(int id, string firstName) : this(id)
        {
            FirstName = firstName;
        }
        public Student(int id, string firstName, string lastName) : this(id, firstName)
        {
            LastName = lastName;
        }
        public Student(int id, string firstName, string lastName, DateTime birthDate) : this(id, firstName, lastName)
        {
            BirthDate = birthDate;
        }
    }
}
