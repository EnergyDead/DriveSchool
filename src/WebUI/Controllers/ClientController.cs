using Application.Clients.Commands;
using Application.Clients.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

public class ClientController : ApiController
{
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var vm = await Mediator.Send(new GetClient { });

        return Ok(await Mediator.Send(vm));
    }

    [HttpGet("login")]
    public async Task<IActionResult> Login(LoginCommand command)
    {
        return Ok(await Mediator.Send(command));
    }

    [HttpGet("logout")]
    public async Task<IActionResult> Logout(LogoutCommand command)
    {
        return Ok(await Mediator.Send(command));
    }
}
