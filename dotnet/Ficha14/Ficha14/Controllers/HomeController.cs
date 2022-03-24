using Ficha14.Models;
using Ficha14.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ficha14.Controllers
{

    public class HomeController : Controller
    {
        private readonly IConfiguration config;
        private readonly IJWTService tokenService;
        private readonly IUserService userService;

        public HomeController(IConfiguration config, IJWTService tokenService, IUserService userService)
        {
            this.config = config;
            this.tokenService = tokenService;
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult SignUp()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public IActionResult Login(User userModel)
        {
            if (string.IsNullOrEmpty(userModel.UserName) || string.IsNullOrEmpty(userModel.Password))
            {
                return (RedirectToAction("Error"));
            }

            var user = userService.Get(userModel.UserName, userModel.Password);
            var validUser = new UserViewModel { UserName = user.UserName, ID = user.ID, Role = user.Role, Email = user.Email };

            if (validUser != null)
            {
                string generatedToken = tokenService.GenerateToken
                (
                    config["Jwt:Key"].ToString(),
                    config["Jwt:Issuer"].ToString(),
                    config["Jwt:Audience"].ToString(),
                    validUser
                );

                if (generatedToken != null)
                {
                    HttpContext.Session.SetString("Token", generatedToken);
                    return RedirectToAction("UserDetails", validUser);
                }
                else
                {
                    return (RedirectToAction("Error"));
                }
            }
            else
            {
                return (RedirectToAction("Error"));
            }
        }

        public IActionResult UserDetails(UserViewModel user)
        {
            string token = HttpContext.Session.GetString("Token");

            if (token == null)
            {
                return (RedirectToAction("Index"));
            }

            if (!tokenService.IsTokenValid(
                config["Jwt:Key"].ToString(),
                config["Jwt:Issuer"].ToString(),
                config["Jwt:Audience"].ToString(),
                token))
            {
                return (RedirectToAction("Index"));
            }

            ViewBag.Token = token;
            return View(user);
        }

    }
}