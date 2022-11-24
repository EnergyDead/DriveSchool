using Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Services;

public class CurrentUserService : ICurrentUserService
{
    public int? UserId => 10;
}
