using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Login")]
    public class LoginController : Controller
    {
        [HttpPost]
        public IActionResult PostLogin([FromBody] Login login)
        {
            if (login.Username != null && login.Password != null)
            {
                if (login.Username.Equals("admin") && login.Password.Equals("1234"))
                {
                    return Ok("Success");
                }
            }
            return BadRequest();
        }
    }
}