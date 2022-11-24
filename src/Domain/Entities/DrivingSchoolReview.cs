namespace Domain.Entities;

public class DrivingSchoolReview
{
    public int Id { get; set; }
    public int Rating { get; set; }
    public string Text { get; set; }
    public Client Client { get; set; }
    public DrivingSchool DrivingSchool { get; set; }

}
