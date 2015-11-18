using ComputerStore.Client.Utils;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class AlaplapController : Controller
    {
        public ActionResult GetByFoglalat(int procFoglalatId, int? pageNumber)
        {
            PageableList<Alaplap> alaplapok = null;

            if(!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                alaplapok = bl.Alaplap_GetByFoglalatID(procFoglalatId, pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            ViewBag.CurrentID = procFoglalatId;

            return View(alaplapok);
        }

        public ActionResult GetByMemoria(int memoriaId, int? pageNumber)
        {
            PageableList<Alaplap> alaplapok = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                alaplapok = bl.Alaplap_GetByMemoriaID(memoriaId, pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            ViewBag.CurrentID = memoriaId;

            return View("GetByFoglalat", alaplapok);
        }
    }
}