using Application.Clients.Commands;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

public class ExamController : ApiController
{
    [HttpGet]
    public async Task<IActionResult> EndureExam()
    {
        return Ok();
    }
}
