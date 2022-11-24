using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

public class FaqController : ApiController
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok();
    }
}
