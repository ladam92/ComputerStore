using ComputerStore.Client.Utils;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class KosarController : Controller
    {
        //
        // GET: /Kosar/
        public ActionResult Index()
        {
            SessionData.Instance.ShowCategories = false;

            return View();
        }

        public ActionResult Delete(string megnevezes, int id)
        {
            var list = SessionData.Instance.Kosar;

            Kategoria kategoria=null;
            foreach (var item in list)
            {
                if (item.ID == id && item.Megnevezes == megnevezes)
                {
                    kategoria = item;
                }
            }

            list.Remove(kategoria);
            SessionData.Instance.Kosar = list;

            return View("Index");
        }

        public ActionResult DeleteFull()
        {
            
            SessionData.Instance.Kosar = new List<Kategoria>();

            return View();
        }
	}
}