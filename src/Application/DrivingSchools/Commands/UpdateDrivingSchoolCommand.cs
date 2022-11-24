using MediatR;

namespace Application.DrivingSchools.Commands;

public class UpdateDrivingSchoolCommand : IRequest
{
    public int Id { get; set; }
}
