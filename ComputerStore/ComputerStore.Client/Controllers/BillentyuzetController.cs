using ComputerStore.Client.Utils;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class BillentyuzetController : Controller
    {
        public ActionResult GetByUsb(int usbId, int? pageNumber)
        {
            PageableList<Billentyuzet> billentyuzet = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                billentyuzet = bl.Billentyuzet_GetByUsbID(usbId, pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            ViewBag.CurrentID = usbId;

            return View(billentyuzet);
        }

 
        public ActionResult GetByPs(int? pageNumber)
        {
            PageableList<Billentyuzet> billentyuzet = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                billentyuzet = bl.Billentyuzet_GetByPs(pageNumber.Value, SessionData.Instance.ListingPageSize);
            }


            return View(billentyuzet);
        }

       


    }
}