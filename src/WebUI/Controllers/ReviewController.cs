using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

public class DrivingSchoolReviewController : ApiController
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok();
    }
}
