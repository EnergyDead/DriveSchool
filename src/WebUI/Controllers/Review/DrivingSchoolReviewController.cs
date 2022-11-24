using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.Review;

[Route("review/[controller]")]
public class DrivingSchoolReviewController : ApiController
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok();
    }
}
