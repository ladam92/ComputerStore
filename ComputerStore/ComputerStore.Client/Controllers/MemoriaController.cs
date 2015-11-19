using ComputerStore.Client.Utils;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class MemoriaController : Controller
    {
        public ActionResult GetByFoglalat(int memFoglalatId, int? pageNumber)
        {
            PageableList<Memoria> memoria = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                memoria = bl.Memoria_GetByFoglalat(memFoglalatId, pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            ViewBag.CurrentID = memFoglalatId;

            return View(memoria);
        }

       
	}
}