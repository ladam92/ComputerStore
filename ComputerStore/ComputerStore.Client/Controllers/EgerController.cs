using ComputerStore.Client.Utils;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class EgerController : Controller
    {
        public ActionResult GetByUsb(int usbId, int? pageNumber)
        {
            PageableList<Eger> eger = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                eger = bl.Eger_GetByUsbID(usbId, pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            ViewBag.CurrentID = usbId;

            return View(eger);
        }

        public ActionResult Kosar(int db, int id)
        {

            Eger eger1; Eger egerkivant;
            using (var bl = new BusinessLogic.LogicClient())
            {
                eger1 = bl.Eger_GetByID(id);
                egerkivant = new Eger
                {
                    ID = eger1.ID,
                    Db = db,
                    Gyarto = eger1.Gyarto,
                    IsPs2 = eger1.IsPs2,
                    Kep = eger1.Kep,
                    NettoAr = eger1.NettoAr,
                    Megnevezes = eger1.Megnevezes,
                    UsbID = eger1.UsbID
                };
            }
            Kategoria k = new Kategoria { ID = egerkivant.ID, Db = egerkivant.Db, Kep = egerkivant.Kep, Megnevezes = egerkivant.Megnevezes, NettoAr = egerkivant.NettoAr };
            SessionData.Instance.Kosar.Add(k);

            return View();
        }

        public ActionResult GetByPs(int? pageNumber)
        {
            PageableList<Eger> eger = null;

            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }

            using (var bl = new BusinessLogic.LogicClient())
            {
                eger = bl.Eger_GetByPs(pageNumber.Value, SessionData.Instance.ListingPageSize);
            }

            return View(eger);
        }

        public ActionResult GetComboBoxByUsb(int usbID)
        {
            List<Eger> model = null;

            using (var bl = new BusinessLogic.LogicClient())
            {
                model = bl.Eger_GetListByUsb(usbID).ToList();
            }

            return PartialView(model);
        }

        public ActionResult GetComboBoxPS2()
        {
            List<Eger> model = null;

            using (var bl = new BusinessLogic.LogicClient())
            {
                model = bl.Eger_GetListPS2().ToList();
            }

            return PartialView(model);
        }
    }
}