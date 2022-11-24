using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

public class DrivingSchoolReviewController : ApiController
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok();
    }
}
