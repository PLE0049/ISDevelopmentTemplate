using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamScheduler.Core.DTO;
using TeamScheduler.Core.Services;

namespace TeamScheduler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService UserService { get; }
        public UserController(UserService userService)
        {
            UserService = userService;
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public UserProfileViewModel Get(int id)
        {
            return UserService.GetUser(id);
        }
    }
}
