using ComputerStore.Client.Utils;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class TapegysegController : Controller
    {
        public ActionResult GetTapegyseg(int? pageNumber)
        {
            PageableList<Tapegyseg> tapegyseg = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                tapegyseg = bl.Tapegyseg_Get(pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            return View(tapegyseg);
        }
	}
}