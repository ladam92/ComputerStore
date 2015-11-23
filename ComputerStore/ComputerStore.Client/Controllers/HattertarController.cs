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

        public ActionResult Kosar(int db, int id)
        {

            Hattertar hattertar1; Hattertar háttértárkivant;
            using (var bl = new BusinessLogic.LogicClient())
            {
                hattertar1 = bl.Hattertar_GetByID(id);
                háttértárkivant = new Hattertar
                {
                    ID = hattertar1.ID,
                    Db = db,
                    Gyarto = hattertar1.Gyarto,
                    Kep = hattertar1.Kep,
                    NettoAr = hattertar1.NettoAr,
                    Megnevezes = hattertar1.Megnevezes,
                    CsatoloID=hattertar1.CsatoloID,
                    Meret=hattertar1.Meret,
                    TipusID=hattertar1.TipusID
                };
            }
            Kategoria k = new Kategoria { ID = háttértárkivant.ID, Db = háttértárkivant.Db, Kep = háttértárkivant.Kep, Megnevezes = háttértárkivant.Megnevezes, NettoAr = háttértárkivant.NettoAr };
            SessionData.Instance.Kosar.Add(k);

            return View();
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