using LoginSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginSample.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            ViewBag.Test = "ahhh";
            return View();


        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            ModelState.AddModelError("Password", "hhhhh");
            ModelState.AddModelError("Email", "llllll");
            return View();
        }
    }
}