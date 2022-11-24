using Application.Common;
using Application.Instructors.Commands;
using Application.Instructors.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

public class InstructorController : ApiController
{
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync(int id)
    {
        var vm = await Mediator.Send(new GetInstructorQuery { Id = id });

        return Ok(vm);
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync(GetInstructorByFilterCommand command)
    {
        return Ok(await Mediator.Send(command));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateInstructorCommand command)
    {
        return Ok(await Mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateInstructorCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }
        await Mediator.Send(command);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await Mediator.Send(new DeleteInstructorCommand(id));

        return NoContent();
    }
}
