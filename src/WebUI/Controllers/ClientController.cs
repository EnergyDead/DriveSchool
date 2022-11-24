using Application.Common;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

public class ClientController : ApiController
{
    private readonly IApplicationDbContext _applicationDbContext;
    public ClientController(IApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return Ok(_applicationDbContext.Client.ToList().First());
    }
}
