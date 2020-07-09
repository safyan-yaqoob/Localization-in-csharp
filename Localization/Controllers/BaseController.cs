using Localization.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Localization.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected override void ExecuteCore()
        {
            int culture = 0;

            if (this.Session == null || this.Session["CurrentCulture"] == null)
            {
                int.TryParse(System.Configuration.ConfigurationManager.AppSettings["Culture"], out culture);
                this.Session["CurrentCulture"] = culture;
            }
            else
            {
                culture = (int)this.Session["CurrentCulture"];
            }

            CultureHelper.Culture = culture;


            base.ExecuteCore();
        }
        protected override bool DisableAsyncSupport
        {
            get
            {
                return true;
            }
        }
    }
}