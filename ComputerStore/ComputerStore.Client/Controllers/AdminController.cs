using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditCategories()
        {
            return View();
        }

        public ActionResult GetCategories(int pageNum)
        {
            return PartialView();
        }
    }
}