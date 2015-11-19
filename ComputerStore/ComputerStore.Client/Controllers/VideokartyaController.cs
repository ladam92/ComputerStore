using ComputerStore.Client.Utils;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class VideokartyaController : Controller
    {
        public ActionResult GetVideokartya(int? pageNumber)
        {
            PageableList<Videokartya> videokartya = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                videokartya = bl.Videokartya_Get(pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            return View(videokartya);
        }
	}
}