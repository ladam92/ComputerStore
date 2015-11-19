using ComputerStore.Client.Utils;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class EgerController : Controller
    {
        public ActionResult GetByUsb(int usbId, int? pageNumber)
        {
            PageableList<Eger> eger = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                eger = bl.Eger_GetByUsbID(usbId, pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            ViewBag.CurrentID = usbId;

            return View(eger);
        }

        public ActionResult GetByPs(int? pageNumber)
        {
            PageableList<Eger> eger = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                eger = bl.Eger_GetByPs(pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            return View(eger);
        }
	}
}