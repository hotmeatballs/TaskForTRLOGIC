using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using TRLogicTask.Models;
using System.Data.Entity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;

namespace TRLogicTask.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()  
        {
            ApplicationUser user = CurrentUser;
            if (user != null)
            {
                ViewBag.userEmail = user.Email;
                ViewBag.userUserName = user.UserName;
                ViewBag.userId = user.Id;
                ViewBag.userPhone = user.PhoneNumber;
                ViewBag.userVerify = user.PhoneNumberConfirmed;
                ViewBag.userVerifyEmail = user.EmailConfirmed;


                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }
        private ApplicationUserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }

        private ApplicationUser CurrentUser
        {
            get
            {
                return UserManager.FindByName(HttpContext.User.Identity.Name);
            }
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}