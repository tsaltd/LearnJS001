using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Middleware;

namespace LearnJS.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            Middleware.JsLabViewModel model = new JsLabViewModel();
           
            return View(model);
        }
    }
}