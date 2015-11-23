using ComputerStore.Client.Utils;
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
        public ActionResult GetByFoglalat(int procFoglalatId, int? pageNumber)
        {
            PageableList<Alaplap> alaplapok = null;

            if(!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                alaplapok = bl.Alaplap_GetByFoglalatID(procFoglalatId, pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            ViewBag.CurrentID = procFoglalatId;

            return View(alaplapok);
        }

        public ActionResult Kosar(int db, int id)
        {
           
            //int db = alaplap.Db; //nem adsz át alaplapot az id jó
            //int db2 = Int32.Parse(db);
            //int id = SessionData.Instance.KategoriaID;
            Alaplap alaplap1; Alaplap alaplapkivant;
            using (var bl = new BusinessLogic.LogicClient())
            {
                alaplap1 = bl.Alaplap_GetByID(id);
                alaplapkivant = new Alaplap
                {
                    ID = alaplap1.ID,
                    Db = db,
                    FoglalatID = alaplap1.FoglalatID,
                    Gyarto = alaplap1.Gyarto,
                    IsPs2 = alaplap1.IsPs2,
                    Kep = alaplap1.Kep,
                    Leiras = alaplap1.Leiras,
                    Megnevezes = alaplap1.Megnevezes,
                    MemoriaDarab = alaplap1.MemoriaDarab,
                    MemoriaFoglalat = alaplap1.MemoriaFoglalat,
                    MemoriaFoglalatID = alaplap1.MemoriaFoglalatID,
                    NettoAr = alaplap1.NettoAr,
                    VGADarab = alaplap1.VGADarab
                };
            }
            Kategoria k = new Kategoria { ID = alaplapkivant.ID, Db = alaplapkivant.Db, Kep = alaplapkivant.Kep, Megnevezes = alaplapkivant.Megnevezes, NettoAr = alaplapkivant.NettoAr };
            SessionData.Instance.Kosar.Add(k);
          
            return View();
        }

        public ActionResult GetByMemoria(int memoriaId, int? pageNumber)
        {
            PageableList<Alaplap> alaplapok = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                alaplapok = bl.Alaplap_GetByMemoriaID(memoriaId, pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            ViewBag.CurrentID = memoriaId;

            return View("GetByFoglalat", alaplapok);
        }
    }
}