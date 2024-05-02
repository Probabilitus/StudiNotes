public class Grade
{
    public double Value { get; set; }
    public string Comment { get; set; }
    public Grade(double value, string comment)
    {
        Value = value;
        Comment = comment;
    }
}

