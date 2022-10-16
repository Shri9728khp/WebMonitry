using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMonitry.DataDbc;

namespace WebMonitry.Controllers
{
    public class MonitryServerTimeController : Controller
    {
        Usb_MonotringEntities dba = new Usb_MonotringEntities();
        public ActionResult TimeOrignal()
        {
            var ard = dba.Monotringins.ToList();
           // response.headers.add("refresh", "120");
            return View(ard);
        }
    }
}