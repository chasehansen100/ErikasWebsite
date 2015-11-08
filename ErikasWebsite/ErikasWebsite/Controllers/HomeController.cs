using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess.EventRepository;

namespace ErikasWebsite.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            EventRepository Events = new EventRepository();
        }
        public ActionResult Index()
        {
            
            return View();
        }
    }
}