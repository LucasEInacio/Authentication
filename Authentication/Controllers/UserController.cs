using Domain;
using Domain.DTOs;
using Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post(UserRequest userRequest)
        {
            return Ok(_service.SaveUser(userRequest));
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult Login(UserLogin login)
        {
            var authenticated = _service.Login(login);
            if (authenticated is null)
                return NotFound(new { message = "User not found" });
            return Ok(authenticated);
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetUsers(int? id)
        {
            return Ok(_service.GetUsers(id));
        }

        [HttpPost("manager")]
        [Authorize(Roles = "manager")]
        public IActionResult manager()
        {
            return Ok(string.Format("You are an Administrator! Be wise {0}!", User.Identity.Name));
        }
    }
}
