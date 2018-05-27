using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ParyInvites2.Models;
namespace ParyInvites2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 17 ? "Dzień dobry" : "Dobry wieczór";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            //do zrobienia: wyślij zawartość guestResponse do organizowania przyjęcia
            if(ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else //do zrobienia: wyślij zawartość guestResponse do organizatora przyjęcia
            return View();
        }
    }
}