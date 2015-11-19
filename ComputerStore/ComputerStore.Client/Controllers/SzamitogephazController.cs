using ComputerStore.Client.Utils;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class SzamitogephazController : Controller
    {
        public ActionResult Gethaz(int? pageNumber)
        {
            PageableList<Szamitogephaz> szamitogephaz = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
               szamitogephaz = bl.Szamitogephaz_Get( pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            return View(szamitogephaz);
        }
	}
}