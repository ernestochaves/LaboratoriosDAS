using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reminders.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Reminder> reminders = GetReminders();

            return View(reminders);
        }

        private static List<Reminder> GetReminders()
        {
            List<Reminder> reminders = new List<Reminder>();
            for (int i = 0; i < 30; i++)
            {
                reminders.Add(new Reminder(i, "Fake Reminder " + i, DateTime.Now.AddDays(i)));
            }

            return reminders;
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