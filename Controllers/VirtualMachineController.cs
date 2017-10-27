using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;

namespace VendingMachineNew.Controllers
{
    public class VirtualMachineController : Controller
    {
        // GET: VirtualMachine
        public ActionResult Index()
        {
            return View();
        }
    }
}