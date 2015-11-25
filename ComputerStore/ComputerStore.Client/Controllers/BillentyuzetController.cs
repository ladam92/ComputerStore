using ComputerStore.Client.Utils;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class BillentyuzetController : Controller
    {
        public ActionResult GetByUsb(int usbId, int? pageNumber)
        {
            PageableList<Billentyuzet> billentyuzet = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                billentyuzet = bl.Billentyuzet_GetByUsbID(usbId, pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            ViewBag.CurrentID = usbId;

            return View(billentyuzet);
        }

        public ActionResult Kosar(int db, int id)
        {

            Billentyuzet billentyuzet1; Billentyuzet billentyuzetkivant;
            using (var bl = new BusinessLogic.LogicClient())
            {
                billentyuzet1 = bl.Billentyuzet_GetByID(id);
                billentyuzetkivant = new Billentyuzet
                {
                    ID = billentyuzet1.ID,
                    Db = db,
                    Gyarto = billentyuzet1.Gyarto,
                    IsPs2 = billentyuzet1.IsPs2,
                    Kep = billentyuzet1.Kep,
                    NettoAr = billentyuzet1.NettoAr,
                    Megnevezes=billentyuzet1.Megnevezes,
                    UsbID=billentyuzet1.UsbID
                };
            }
            Kategoria k = new Kategoria { ID = billentyuzetkivant.ID, Db = billentyuzetkivant.Db, Kep = billentyuzetkivant.Kep, Megnevezes = billentyuzetkivant.Megnevezes, NettoAr = billentyuzetkivant.NettoAr };
            SessionData.Instance.Kosar.Add(k);

            return View();
        }

 
        public ActionResult GetByPs(int? pageNumber)
        {
            PageableList<Billentyuzet> billentyuzet = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                billentyuzet = bl.Billentyuzet_GetByPs(pageNumber.Value, SessionData.Instance.ListingPageSize);
            }


            return View(billentyuzet);
        }

       


    }
}