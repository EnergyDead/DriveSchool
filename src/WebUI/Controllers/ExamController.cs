using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

public class ExamController : ApiController
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok();
    }
}
