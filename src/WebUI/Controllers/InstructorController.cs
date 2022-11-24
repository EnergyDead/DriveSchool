using Application.Common;
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
}
