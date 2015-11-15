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
        public ActionResult GetByFoglalat(int procFoglalatId)
        {
            List<Alaplap> alaplapok = null;

            using (var bl = new BusinessLogic.LogicClient())
            {
                alaplapok = bl.Alaplap_GetByFoglalatID(procFoglalatId).ToList();
            }

            return View(alaplapok);
        }
    }
}