using Application.DrivingSchools.Queries;
using Application.DrivingSchools.Commands;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

public class DrivingSchoolController : ApiController
{
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync(int id)
    {
        var vm = await Mediator.Send(new GetClientSchool {});

        return Ok(vm);
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync(GetDrivingSchoolByFilterCommand command)
    {
        return Ok(await Mediator.Send(command));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateDrivingSchoolCommand command)
    {
        return Ok(await Mediator.Send(command));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateDrivingSchoolCommand command)
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
        await Mediator.Send(new DeleteDrivingSchoolCommand(id));

        return NoContent();
    }
}
