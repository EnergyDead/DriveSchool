namespace Domain.Entities;

public class Exam
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public Client Client { get; set; }
}
