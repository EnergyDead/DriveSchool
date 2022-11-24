using MediatR;

namespace Application.Clients.Commands;

public class LogoutCommand : IRequest
{
    int Id { get; set; }
}
