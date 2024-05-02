namespace StudiNotes
{
    public class Course

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        public Course(int id, string name)
        {
            Id = id;
            Name = name;
            Courses = new List<Course>();
        }
    }
}