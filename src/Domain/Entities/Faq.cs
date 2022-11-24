namespace Domain.Entities;

public class Faq
{
    public int Id { get; set; }
    public string Text { get; set; }
    public DrivingSchool DrivingSchool { get; set; }
}
