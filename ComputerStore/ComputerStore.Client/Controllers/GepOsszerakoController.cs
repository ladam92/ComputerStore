using ComputerStore.Client.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class GepOsszerakoController : Controller
    {
        // GET: GepOsszerako
        public ActionResult Index()
        {
            SessionData.Instance.ShowCategories = false;

            return View();
        }
    }
}