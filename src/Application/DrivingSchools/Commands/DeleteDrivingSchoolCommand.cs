using MediatR;

namespace Application.DrivingSchools.Commands;

public record DeleteDrivingSchoolCommand(int Id) : IRequest;
