using ComputerStore.Client.Utils;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class ProcesszorController : Controller
    {
        public ActionResult GetByFoglalat(int procFoglalatId, int? pageNumber)
        {
            PageableList<Processzor> processzor = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                processzor = bl.Processzor_GetByFoglalat(procFoglalatId, pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            ViewBag.CurrentID = procFoglalatId;

            return View(processzor);
        }
	}
}