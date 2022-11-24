using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

public class DrivingSchoolController : ApiController
{
    [HttpGet]
    public IActionResult Index1()
    {
        return Ok();
    }
}
