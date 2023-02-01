using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SMTI_Teacher_Course_Management.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SMTI_Teacher_Course_Management.Controllers
{
    public class HomeController : Controller
    {
          private readonly SMTITeacherCourseManagementDBContext _context;

        public HomeController(SMTITeacherCourseManagementDBContext context)
        {
            _context = context;
        }


        [Authorize]
        public IActionResult Index()
        {
            return View();
        }


        

        public IActionResult TeacherView()
        {

            return View();
        }


            public IActionResult Login(string error)
        {
            if (error != null)
            {

                ViewData["ErrorMessage"] = error;
                ViewData["hasMessage"] = "True";


            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(int userid, string password)
        {
            bool uservalidation = _context.Users.Any(u => u.UserId == userid && u.Password == password);
            if (uservalidation)
            {


                
                string type = (from Em in _context.Employees where Em.EmployeeNumber == userid select Em.JobTitle).FirstOrDefault();
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Sid, userid.ToString()),
                        new Claim(ClaimTypes.Role, type.ToString()),
                    };
                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {

                    ExpiresUtc = DateTime.Now.AddMinutes(30),
                };

                await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
               new ClaimsPrincipal(claimsIdentity), authProperties);
                if (type == "Teacher")
                {
                    

                    Authentification.userLogged = _context.Users.FirstOrDefault(x => x.UserId == userid)!;

                   

                    return RedirectToAction("TeacherView", "home");

                }

                if (type == "Program Coordinator")
                {
                    Authentification.userLogged = _context.Users.FirstOrDefault(x => x.UserId == userid)!;

                    return RedirectToAction("Index", "home");

                }









            }
            return RedirectToAction("Login", new { Error = "Invalid Password or Id" });

        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
