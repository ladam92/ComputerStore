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
        public ActionResult Index()
        {
            SessionData.Instance.ShowCategories = false;

            return View();
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