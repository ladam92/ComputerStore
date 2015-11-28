using ComputerStore.Client.Models;
using ComputerStore.Client.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class GepOsszerakoController : Controller
    {
        public object GeposszerakoViewModel { get; private set; }

        // GET: GepOsszerako
        [HttpGet]
        public ActionResult Index()
        {
            SessionData.Instance.ShowCategories = false;

            return View();
        }

        [HttpPost]
        public ActionResult Index(GepOsszerakoViewModel model)
        {
            using (var bl = new BusinessLogic.LogicClient())
            {
                if(model.AlaplapID.HasValue)
                {
                    var alaplap = bl.Alaplap_GetByID(model.AlaplapID.Value);
                    alaplap.Db = 1;
                    SessionData.Instance.Kosar.Add(alaplap);
                }

                if(model.Processzor.HasValue)
                {
                    var proc = bl.Processzor_GetByID(model.Processzor.Value);
                    proc.Db = 1;
                    SessionData.Instance.Kosar.Add(proc);
                }

                foreach (var item in model.Memoria)
                {
                    if(item.HasValue)
                    {
                        var memoria = bl.Memoria_GetByID(item.Value);
                        memoria.Db = 1;
                        SessionData.Instance.Kosar.Add(memoria);
                    }
                }

                foreach (var item in model.Videokartya)
                {
                    if (item.HasValue)
                    {
                        var videokartya = bl.Videokartya_GetByID(item.Value);
                        videokartya.Db = 1;
                        SessionData.Instance.Kosar.Add(videokartya);
                    }
                }

                if (model.Hattertar.HasValue)
                {
                    var hattertar = bl.Hattertar_GetByID(model.Hattertar.Value);
                    hattertar.Db = 1;
                    SessionData.Instance.Kosar.Add(hattertar);
                }
                if (model.Billentyuzet.HasValue)
                {
                    var billentyuzet = bl.Billentyuzet_GetByID(model.Billentyuzet.Value);
                    billentyuzet.Db = 1;
                    SessionData.Instance.Kosar.Add(billentyuzet);
                }

                if(model.Eger.HasValue)
                {
                    var eger = bl.Eger_GetByID(model.Eger.Value);
                    eger.Db = 1;
                    SessionData.Instance.Kosar.Add(eger);
                }

                if(model.Monitor.HasValue)
                {
                    var monitor = bl.Monitor_GetByID(model.Monitor.Value);
                    monitor.Db = 1;
                    SessionData.Instance.Kosar.Add(monitor);
                }

                if(model.SzamitogepHaz.HasValue)
                {
                    var szamitogepHaz = bl.Szamitogephaz_GetByID(model.SzamitogepHaz.Value);
                    szamitogepHaz.Db = 1;
                    SessionData.Instance.Kosar.Add(szamitogepHaz);
                }

                if(model.Tapegyseg.HasValue)
                {
                    var tapegyseg = bl.Tapegyseg_GetByID(model.Tapegyseg.Value);
                    tapegyseg.Db = 1;
                    SessionData.Instance.Kosar.Add(tapegyseg);
                }
            }

            return RedirectToAction("Index", "Kosar");
        }

        public ActionResult GetGeposszarkoComboBoxes(int alaplapID)
        {
            GepOsszerakoViewModel model = new GepOsszerakoViewModel();

            using (var bl = new BusinessLogic.LogicClient())
            {
                model.Alaplap = bl.Alaplap_GetByID(alaplapID);
                model.ProcesszorList = bl.Processzor_GetListByFoglalat(model.Alaplap.FoglalatID).ToList();
                model.MemoriaList = bl.Memoria_GetListByFoglalat(model.Alaplap.MemoriaFoglalatID).ToList();
                model.VideoKartyaList = bl.Videokartya_GetList().ToList();
                model.UsbTipusList = bl.Alaplap_GetUsbTipusok(alaplapID).ToList();
                model.SzamitogephazList = bl.SzamitogepHaz_GetList().ToList();
                model.TapegysegList = bl.Tapegyseg_GetList().ToList();
            }

            return PartialView(model);
        }
    }
}