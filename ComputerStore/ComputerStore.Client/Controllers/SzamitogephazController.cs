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

        public ActionResult Kosar(int db, int id)
        {

            Szamitogephaz szamitogephaz1; Szamitogephaz szamitogephazkivant;
            using (var bl = new BusinessLogic.LogicClient())
            {
                szamitogephaz1 = bl.Szamitogephaz_GetByID(id);
                szamitogephazkivant = new Szamitogephaz
                {
                    ID = szamitogephaz1.ID,
                    Db = db,
                    Gyarto = szamitogephaz1.Gyarto,
                    Kep = szamitogephaz1.Kep,
                    NettoAr = szamitogephaz1.NettoAr,
                    Megnevezes = szamitogephaz1.Megnevezes,
                    
                };
            }
            Kategoria k = new Kategoria { ID = szamitogephazkivant.ID, Db = szamitogephazkivant.Db, Kep = szamitogephazkivant.Kep, Megnevezes = szamitogephazkivant.Megnevezes, NettoAr = szamitogephazkivant.NettoAr };
            SessionData.Instance.Kosar.Add(k);

            return View();
        }
	}
}