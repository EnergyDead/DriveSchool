using MediatR;

namespace Application.Instructors.Commands
{
    public record DeleteInstructorCommand(int Id) : IRequest;
}
