@model user
using CI_PLatform_Web.Models;
namespace CI_PLatform_Web.Controllers
{
    public class LoginController
    {
       
            public CiPlatformContext = new CiPlatformContext();


            public IActionResult Login()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Login(User model)
            {
                var user = ci_platform.Users.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);

                if (user == null)
                {
                    TempData["utsav"] = "utsav not exist";
                    return View();
                }

                return RedirectToAction("Index", "Home");
            }


        }
    }
