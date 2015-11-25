using ComputerStore.Client.Utils;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class MonitorController : Controller
    {
        public ActionResult GetByMeret(int meretId, int? pageNumber)
        {
            PageableList<Monitor> monitor = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                monitor = bl.Monitor_GetByMeret(meretId, pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            ViewBag.CurrentID = meretId;

            return View(monitor);
        }

        public ActionResult Kosar(int db, int id)
        {

            Monitor monitor1; Monitor monitorkivant;
            using (var bl = new BusinessLogic.LogicClient())
            {
                monitor1 = bl.Monitor_GetByID(id);
                monitorkivant = new Monitor
                {
                    ID = monitor1.ID,
                    Db = db,
                    Gyarto = monitor1.Gyarto,
                    Kep = monitor1.Kep,
                    NettoAr = monitor1.NettoAr,
                    Megnevezes = monitor1.Megnevezes,
                    CsatoloID=monitor1.CsatoloID,
                    FelbontasID=monitor1.FelbontasID,
                    MeretID=monitor1.MeretID
                };
            }
            Kategoria k = new Kategoria { ID = monitorkivant.ID, Db = monitorkivant.Db, Kep = monitorkivant.Kep, Megnevezes = monitorkivant.Megnevezes, NettoAr = monitorkivant.NettoAr };
            SessionData.Instance.Kosar.Add(k);

            return View();
        }

        public ActionResult GetByFelbontas(int felbontasId, int? pageNumber)
        {
            PageableList<Monitor> monitor = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                monitor = bl.Monitor_GetByFelbontas(felbontasId, pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            ViewBag.CurrentID = felbontasId;

            return View(monitor);
        }
	}
}