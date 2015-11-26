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

        public ActionResult GetComboBoxByAlaplap(int alaplapID)
        {
            List<Memoria> memoria = null;


            using (var bl = new BusinessLogic.LogicClient())
            {
                var alaplap = bl.Alaplap_GetByID(alaplapID);
                memoria = bl.Memoria_GetListByFoglalat(alaplap.MemoriaFoglalatID).ToList();
            }


            return PartialView(memoria);
        }

        public ActionResult Kosar(int db, int id)
        {

            Memoria memoria1; Memoria memoriakivant;
            using (var bl = new BusinessLogic.LogicClient())
            {
                memoria1 = bl.Memoria_GetByID(id);
                memoriakivant = new Memoria
                {
                    ID = memoria1.ID,
                    Db = db,
                    Gyarto = memoria1.Gyarto,
                    Kep = memoria1.Kep,
                    NettoAr = memoria1.NettoAr,
                    Megnevezes = memoria1.Megnevezes,
                    FoglalatID=memoria1.FoglalatID,
                    MemoriaMeret=memoria1.MemoriaMeret
                };
            }
            Kategoria k = new Kategoria { ID = memoriakivant.ID, Db = memoriakivant.Db, Kep = memoriakivant.Kep, Megnevezes = memoriakivant.Megnevezes, NettoAr = memoriakivant.NettoAr };
            SessionData.Instance.Kosar.Add(k);

            return View();
        }
       
	}
}