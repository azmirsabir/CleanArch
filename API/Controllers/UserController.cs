using Application.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("/user")]
public class UserController(IUserService userService)
{
    [HttpGet]
    public string GetUser() {
        return userService.GetUser();
    }
}