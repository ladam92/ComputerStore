using ComputerStore.Client.Utils;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class MonitorController : Controller
    {
        public ActionResult GetByMeret(int meretId, int? pageNumber)
        {
            PageableList<Monitor> monitor = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                monitor = bl.Monitor_GetByMeret(meretId, pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            ViewBag.CurrentID = meretId;

            return View(monitor);
        }

        public ActionResult GetByFelbontas(int felbontasId, int? pageNumber)
        {
            PageableList<Monitor> monitor = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                monitor = bl.Monitor_GetByFelbontas(felbontasId, pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            ViewBag.CurrentID = felbontasId;

            return View(monitor);
        }
	}
}