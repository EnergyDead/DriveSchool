namespace Domain.Entities;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PathToImage { get; set; }
    public DrivingSchool DrivingSchool { get; set; }
}
