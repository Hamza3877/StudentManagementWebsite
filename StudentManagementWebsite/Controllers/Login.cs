using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementWebsite.Controllers
{
    public class Login : Controller
    {

        private readonly smgdbContext ORM = null;


        public Login(smgdbContext _ORM) {

            ORM = _ORM;

/*files*/
     }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(User objch)
        {

     

             

                    User LoginUser = ORM.User.Where(a => a.Username.Equals(objch.Username) && a.Password.Equals(objch.Password)).FirstOrDefault();

                    if (LoginUser == null)
                    {


                ModelState.AddModelError("", "UserName and Password is not Correct");

                    return View();

                    }



                HttpContext.Session.SetString("UserId", LoginUser.Id.ToString());

                HttpContext.Session.SetString("UserName", LoginUser.Username);

                return RedirectToAction("Index", "Home");

              


                    
                    
                  

                }


           


       


        public IActionResult Logout()
        {

            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");

         
        }

    }
    }

