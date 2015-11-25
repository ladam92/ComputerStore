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

        public ActionResult Kosar(int db, int id)
        {

            Videokartya videokartya1; Videokartya videokartyakivant;
            using (var bl = new BusinessLogic.LogicClient())
            {
                videokartya1 = bl.Videokartya_GetByID(id);
                videokartyakivant = new Videokartya
                {
                    ID = videokartya1.ID,
                    Db = db,
                    Gyarto = videokartya1.Gyarto,
                    Kep = videokartya1.Kep,
                    NettoAr = videokartya1.NettoAr,
                    Megnevezes = videokartya1.Megnevezes,
                    MemoriaMeret = videokartya1.MemoriaMeret,
                    MemoriaTipusID=videokartya1.MemoriaTipusID
                };
            }
            Kategoria k = new Kategoria { ID = videokartyakivant.ID, Db = videokartyakivant.Db, Kep = videokartyakivant.Kep, Megnevezes = videokartyakivant.Megnevezes, NettoAr = videokartyakivant.NettoAr };
            SessionData.Instance.Kosar.Add(k);

            return View();
        }
	}
}