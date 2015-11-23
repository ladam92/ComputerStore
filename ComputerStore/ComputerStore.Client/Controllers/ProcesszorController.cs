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

        public ActionResult Kosar(int db, int id)
        {

            Processzor processzor1; Processzor processzorkivant;
            using (var bl = new BusinessLogic.LogicClient())
            {
                processzor1 = bl.Processzor_GetByID(id);
                processzorkivant = new Processzor
                {
                    ID = processzor1.ID,
                    Db = db,
                    Gyarto = processzor1.Gyarto,
                    Kep = processzor1.Kep,
                    NettoAr = processzor1.NettoAr,
                    Megnevezes = processzor1.Megnevezes,
                    Frekvencia=processzor1.Frekvencia,
                    FrekvenciaMertekID=processzor1.FrekvenciaMertekID,
                    Magok=processzor1.Magok,
                    ProcFoglalatID=processzor1.ProcFoglalatID
                };
            }
            Kategoria k = new Kategoria { ID = processzorkivant.ID, Db = processzorkivant.Db, Kep = processzorkivant.Kep, Megnevezes = processzorkivant.Megnevezes, NettoAr = processzorkivant.NettoAr };
            SessionData.Instance.Kosar.Add(k);

            return View();
        }
	}
}