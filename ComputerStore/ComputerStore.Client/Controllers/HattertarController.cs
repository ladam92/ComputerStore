using ComputerStore.Client.Utils;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class HattertarController : Controller
    {
        public ActionResult GetByHattertarCsatolo(int csatoloId, int? pageNumber)
        {
            PageableList<Hattertar> hattertar = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                hattertar = bl.Hattertar_GetByHattertarCsatolo(csatoloId, pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            ViewBag.CurrentID = csatoloId;

            return View(hattertar);
        }

        public ActionResult GetByHattertarTipus(int tipusId, int? pageNumber)
        {
            PageableList<Hattertar> hattertar = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                hattertar = bl.Hattertar_GetByHattertarCsatolo(tipusId, pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            ViewBag.CurrentID = tipusId;

            return View(hattertar);
        }
	}
}