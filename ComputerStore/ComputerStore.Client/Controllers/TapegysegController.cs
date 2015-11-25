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

        public ActionResult Kosar(int db, int id)
        {

            Tapegyseg tapegyseg1; Tapegyseg tápegysegkivant;
            using (var bl = new BusinessLogic.LogicClient())
            {
                tapegyseg1 = bl.Tapegyseg_GetByID(id);
                tápegysegkivant = new Tapegyseg
                {
                    ID = tapegyseg1.ID,
                    Db = db,
                    Gyarto = tapegyseg1.Gyarto,
                    Kep = tapegyseg1.Kep,
                    NettoAr = tapegyseg1.NettoAr,
                    Megnevezes = tapegyseg1.Megnevezes,
                    Teljesitmeny=tapegyseg1.Teljesitmeny
                };
            }
            Kategoria k = new Kategoria { ID = tápegysegkivant.ID, Db = tápegysegkivant.Db, Kep = tápegysegkivant.Kep, Megnevezes = tápegysegkivant.Megnevezes, NettoAr = tápegysegkivant.NettoAr };
            SessionData.Instance.Kosar.Add(k);

            return View();
        }
	}
}