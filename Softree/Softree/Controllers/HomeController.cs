using Softree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Softree.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Night";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestresponse)
        {
            if (ModelState.IsValid)
            {


                //TODO:Email response to the party organizer
                return View("Thanks", guestresponse);
            }
            else
            {
                //There is a validation error
                return View();
            }
        }
    }
}