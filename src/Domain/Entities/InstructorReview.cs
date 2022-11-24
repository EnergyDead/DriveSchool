namespace Domain.Entities;

public class InstructorReview
{
    public int Id { get; set; }
    public int Rating { get; set; }
    public string Text { get; set; }
    public Client Client { get; set; }
    public Instructor Instructor { get; set; }
}
