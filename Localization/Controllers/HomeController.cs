using Localization.Helper;
using MvcLocalization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Localization.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new UserDetail());
        }

        public ActionResult ChangeCurrentCulture(int id)
        {
            CultureHelper.Culture = id;
        }
    }
}