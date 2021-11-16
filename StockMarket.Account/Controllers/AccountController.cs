using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Account.Entities;
using StockMarket.Account.Models;
using StockMarket.Account.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.Account.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserRepository repository = new UserRepository();
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(User user)
        {
            try
            {
                repository.Register(user);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(Login login)
        {
            try
            {
                User user = repository.Validate(login);
                return Ok(user);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}
