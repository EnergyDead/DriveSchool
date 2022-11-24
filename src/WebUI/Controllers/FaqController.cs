using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

public class FaqController : ApiController
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok();
    }
}
