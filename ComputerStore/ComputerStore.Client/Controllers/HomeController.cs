using ComputerStore.Client.Utils;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SessionData.Instance.ShowCategories = true;

            using (var bl = new BusinessLogic.LogicClient())
            {
                SessionData.Instance.MemList = bl.MemoriaFoglalat_GetKaegoriak().ToList();
                SessionData.Instance.ProcList = bl.ProcFoglalat_GetKategoriak().ToList();
                SessionData.Instance.UsbList = bl.UsbTipus_GetKaegoriak().ToList();
                SessionData.Instance.HattertarList = bl.HattertatTipus_GetKaegoriak().ToList();
                SessionData.Instance.HattertarCsatoloList = bl.HattertatCsatoloTipus_GetKaegoriak().ToList();
                SessionData.Instance.MonitorFelbontasList = bl.MonitorFelbontasTipus_GetKaegoriak().ToList();
                SessionData.Instance.MonitorMeretList = bl.MonitorMeretTipus_GetKaegoriak().ToList();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}