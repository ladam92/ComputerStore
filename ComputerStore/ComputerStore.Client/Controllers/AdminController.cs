using ComputerStore.Client.Models;
using ComputerStore.Client.Utils;
using ComputerStore.DTO.Enums;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AlaplapInsertSave(string megnev, string hatdb, string usbdb, string ar, string db, string vgadb, string memdb, AlaplapViewModel alaplap, HttpPostedFileBase myPhoto)
        {

            if (ModelState.IsValid)
            {
                if (myPhoto == null)
                {
                    ModelState.AddModelError("Kep", "Kép megadása kötelező!");

                    using (var bl = new BusinessLogic.LogicClient())
                    {
                        var gyarto = bl.GyartoGet();
                        alaplap.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                        alaplap.ProcFoglalat = new SelectList(bl.ProcesszorGet(), "ID", "Megnevezes");
                        alaplap.MemoriaFoglalatList = new SelectList(bl.MemoriaGet(), "ID", "Megnevezes");
                        alaplap.VGACsatolo = new SelectList(bl.VgaGet(), "ID", "Megnevezes");
                        alaplap.PCIExpressz = new SelectList(bl.PciGet(), "ID", "Megnevezes");
                        alaplap.USBList = new SelectList(bl.UsbGet(), "ID", "Megnevezes");
                        alaplap.HattertarCsatoloList = new SelectList(bl.HattertarCsatoloTipusGet(), "ID", "Megnevezes");
                    }
                    return View("AlaplapInserting", alaplap);
                }
                else
                {
                    int ar1 = Int32.Parse(ar);
                    int db1 = Int32.Parse(db);
                    int vgadb1 = Int32.Parse(vgadb);
                    int memdb1 = Int32.Parse(memdb);
                    int hatdb1 = Int32.Parse(hatdb);
                    int usbdb1 = Int32.Parse(usbdb);

                    byte[] kep = null;
                    if (myPhoto != null && myPhoto.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(myPhoto.FileName);
                        var path = Path.Combine(Server.MapPath("~/Downloads"), fileName);
                        myPhoto.SaveAs(path);
                        kep = System.IO.File.ReadAllBytes(path);
                    }

                    using (var bl = new BusinessLogic.LogicClient())
                    {
 
                        bl.InsertingAlaplapDB(alaplap.USBID, alaplap.HattertarCsatoloID, alaplap.Gyarto, alaplap.FoglalatID, alaplap.MemoriaFoglalatID, alaplap.VGAID, alaplap.PCIID, memdb1, vgadb1, alaplap.IsPs2, megnev, ar1, db1, kep, hatdb1, usbdb1);
                    }
                    return View();
                }
            }
            else
            {
                using (var bl = new BusinessLogic.LogicClient())
                {
                    var gyarto = bl.GyartoGet();
                    alaplap.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                    alaplap.ProcFoglalat = new SelectList(bl.ProcesszorGet(), "ID", "Megnevezes");
                    alaplap.MemoriaFoglalatList = new SelectList(bl.MemoriaGet(), "ID", "Megnevezes");
                    alaplap.VGACsatolo = new SelectList(bl.VgaGet(), "ID", "Megnevezes");
                    alaplap.PCIExpressz = new SelectList(bl.PciGet(), "ID", "Megnevezes");
                    alaplap.USBList = new SelectList(bl.UsbGet(), "ID", "Megnevezes");
                    alaplap.HattertarCsatoloList = new SelectList(bl.HattertarCsatoloTipusGet(), "ID", "Megnevezes");
                }
                return View("AlaplapInserting", alaplap);
            }

        }

        public ActionResult BillentyuzetInsertSave(string megnev, string ar, string db, BillentyuzetViewModel billentyuzet, HttpPostedFileBase myPhoto)
        {
            if (ModelState.IsValid)
            {
                if (myPhoto == null)
                {
                    ModelState.AddModelError("Kep", "Kép megadása kötelező!");

                    using (var bl = new BusinessLogic.LogicClient())
                    {
                        var gyarto = bl.GyartoGet();
                        billentyuzet.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                        billentyuzet.USBList = new SelectList(bl.UsbGet(), "ID", "Megnevezes");
                    }
                    return View("BillentyuzetInserting", billentyuzet);
                }
                else
                {
                    int ar1 = Int32.Parse(ar);
                    int db1 = Int32.Parse(db);


                    byte[] kep = null;
                    if (myPhoto != null && myPhoto.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(myPhoto.FileName);
                        var path = Path.Combine(Server.MapPath("~/Downloads"), fileName);
                        myPhoto.SaveAs(path);
                        kep = System.IO.File.ReadAllBytes(path);
                    }

                    using (var bl = new BusinessLogic.LogicClient())
                    {

                        bl.InsertingBillentyuzetDB( billentyuzet.Gyarto, billentyuzet.UsbID, billentyuzet.IsPs2, megnev, ar1, db1, kep);
                    }
                    return View();
                }
            }
            else
            {
                using (var bl = new BusinessLogic.LogicClient())
                {
                    var gyarto = bl.GyartoGet();
                    billentyuzet.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                    billentyuzet.USBList = new SelectList(bl.UsbGet(), "ID", "Megnevezes");
                   
                }
                return View("BillentyuzetInserting", billentyuzet);
            }
        }

        public ActionResult HattertarInsertSave(string megnev, string ar, string db, string meret, HattertarViewModel hat, HttpPostedFileBase myPhoto)
        {
                 if (ModelState.IsValid)
            {
                if (myPhoto == null)
                {
                    ModelState.AddModelError("Kep", "Kép megadása kötelező!");

                    using (var bl = new BusinessLogic.LogicClient())
                    {
                        var gyarto = bl.GyartoGet();
                        hat.HattertarTipus = new SelectList(bl.HattertarTipusGet(), "ID", "Megnevezes");
                        hat.HattertarCsatoloTipus=new SelectList(bl.HattertarCsatoloTipusGet(), "ID", "Megnevezes");                 
                        hat.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                        
                    }
                    return View("HattertarInserting", hat);
                }
                else
                {
                    int ar1 = Int32.Parse(ar);
                    int db1 = Int32.Parse(db);
                    int meret1 = Int32.Parse(meret);

                    byte[] kep = null;
                    if (myPhoto != null && myPhoto.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(myPhoto.FileName);
                        var path = Path.Combine(Server.MapPath("~/Downloads"), fileName);
                        myPhoto.SaveAs(path);
                        kep = System.IO.File.ReadAllBytes(path);
                    }

                    using (var bl = new BusinessLogic.LogicClient())
                    {

                        bl.InsertingHattertarDB( hat.Gyarto, hat.CsatoloID, hat.TipusID, megnev, ar1, db1, meret1, kep);
                    }
                    return View();
                }
            }
            else
            {
                using (var bl = new BusinessLogic.LogicClient())
                {
                    var gyarto = bl.GyartoGet();
                    hat.HattertarTipus = new SelectList(bl.HattertarTipusGet(), "ID", "Megnevezes");
                    hat.HattertarCsatoloTipus = new SelectList(bl.HattertarCsatoloTipusGet(), "ID", "Megnevezes");
                    hat.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                   
                }
                return View("HattertarInserting", hat);
            }
        }

        public ActionResult EgerInsertSave(string megnev, string ar, string db, EgerViewModel eger, HttpPostedFileBase myPhoto)
        {
            if (ModelState.IsValid)
            {
                if (myPhoto == null)
                {
                    ModelState.AddModelError("Kep", "Kép megadása kötelező!");

                    using (var bl = new BusinessLogic.LogicClient())
                    {
                        var gyarto = bl.GyartoGet();
                        eger.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                        eger.USBList = new SelectList(bl.UsbGet(), "ID", "Megnevezes");
                    }
                    return View("EgerInserting", eger);
                }
                else
                {
                    int ar1 = Int32.Parse(ar);
                    int db1 = Int32.Parse(db);


                    byte[] kep = null;
                    if (myPhoto != null && myPhoto.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(myPhoto.FileName);
                        var path = Path.Combine(Server.MapPath("~/Downloads"), fileName);
                        myPhoto.SaveAs(path);
                        kep = System.IO.File.ReadAllBytes(path);
                    }

                    using (var bl = new BusinessLogic.LogicClient())
                    {

                        bl.InsertingEgerDB(eger.Gyarto, eger.UsbID, eger.IsPs2, megnev, ar1, db1, kep);
                    }
                    return View();
                }
            }
            else
            {
                using (var bl = new BusinessLogic.LogicClient())
                {
                    var gyarto = bl.GyartoGet();
                    eger.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                    eger.USBList = new SelectList(bl.UsbGet(), "ID", "Megnevezes");

                }
                return View("EgerInserting", eger);
            }
        }

        public ActionResult MemoriaInsertSave(string megnev, string ar, string db, string meret, MemoriaViewModel mem, HttpPostedFileBase myPhoto)
        {
            if (ModelState.IsValid)
            {
                if (myPhoto == null)
                {
                    ModelState.AddModelError("Kep", "Kép megadása kötelező!");

                    using (var bl = new BusinessLogic.LogicClient())
                    {
                        var gyarto = bl.GyartoGet();
                        mem.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                        mem.MemoriaFoglalatTipus = new SelectList(bl.MemoriaGet(), "ID", "Megnevezes");
                    }
                    return View("MemoriaInserting", mem);
                }
                else
                {
                    int ar1 = Int32.Parse(ar);
                    int db1 = Int32.Parse(db);
                    int meret1 = Int32.Parse(meret);

                    byte[] kep = null;
                    if (myPhoto != null && myPhoto.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(myPhoto.FileName);
                        var path = Path.Combine(Server.MapPath("~/Downloads"), fileName);
                        myPhoto.SaveAs(path);
                        kep = System.IO.File.ReadAllBytes(path);
                    }

                    using (var bl = new BusinessLogic.LogicClient())
                    {

                        bl.InsertingMemoriaDB( mem.Gyarto, mem.FoglalatID, megnev, ar1, db1, meret1, kep);
                    }
                    return View();
                }
            }
            else
            {
                using (var bl = new BusinessLogic.LogicClient())
                {
                    var gyarto = bl.GyartoGet();
                    mem.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                    mem.MemoriaFoglalatTipus = new SelectList(bl.MemoriaGet(), "ID", "Megnevezes");

                }
                return View("MemoriaInserting", mem);
            }
        }

        public ActionResult MonitorInsertSave(string megnev, string ar, string db, MonitorViewModel monitor, HttpPostedFileBase myPhoto)
        {
            if (ModelState.IsValid)
            {
                if (myPhoto == null)
                {
                    ModelState.AddModelError("Kep", "Kép megadása kötelező!");

                    using (var bl = new BusinessLogic.LogicClient())
                    {
                        var gyarto = bl.GyartoGet();
                        monitor.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                        monitor.MonitorCsatolo = new SelectList(bl.MonitorCsatoloTipusGet(), "ID", "Megnevezes");
                        monitor.MonitorFelbontas = new SelectList(bl.MonitorFelbontasGet(), "ID", "Megnevezes");
                        monitor.MonitorMeret = new SelectList(bl.MonitorMeretGet(), "ID", "Megnevezes");
                    }
                    return View("MonitorInserting", monitor);
                }
                else
                {
                    int ar1 = Int32.Parse(ar);
                    int db1 = Int32.Parse(db);

                    byte[] kep = null;
                    if (myPhoto != null && myPhoto.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(myPhoto.FileName);
                        var path = Path.Combine(Server.MapPath("~/Downloads"), fileName);
                        myPhoto.SaveAs(path);
                        kep = System.IO.File.ReadAllBytes(path);
                    }

                    using (var bl = new BusinessLogic.LogicClient())
                    {

                        bl.InsertingMonitorDB( monitor.Gyarto, monitor.CsatoloID, monitor.FelbontasID, monitor.MeretID, megnev, ar1, db1, kep);
                    }
                    return View();
                }
            }
            else
            {
                using (var bl = new BusinessLogic.LogicClient())
                {
                    var gyarto = bl.GyartoGet();
                    monitor.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                    monitor.MonitorCsatolo = new SelectList(bl.MonitorCsatoloTipusGet(), "ID", "Megnevezes");
                    monitor.MonitorFelbontas = new SelectList(bl.MonitorFelbontasGet(), "ID", "Megnevezes");
                    monitor.MonitorMeret = new SelectList(bl.MonitorMeretGet(), "ID", "Megnevezes");

                }
                return View("MonitorInserting", monitor);
            }
        }

        public ActionResult CPUInsertSave(string megnev, string ar, string db, string magok, string frek, ProcesszorViewModel processzor, HttpPostedFileBase myPhoto)
        {
            if (ModelState.IsValid)
            {
                if (myPhoto == null)
                {
                    ModelState.AddModelError("Kep", "Kép megadása kötelező!");

                    using (var bl = new BusinessLogic.LogicClient())
                    {
                        var gyarto = bl.GyartoGet();
                        processzor.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                        processzor.ProcFoglalatList = new SelectList(bl.ProcesszorGet(), "ID", "Megnevezes");
                    }
                    return View("CPUInserting", processzor);
                }
                else
                {
                    int ar1 = Int32.Parse(ar);
                    int db1 = Int32.Parse(db);
                    int magok1 = Int32.Parse(magok);
                    int frekvencia1 = Int32.Parse(frek);

                    byte[] kep = null;
                    if (myPhoto != null && myPhoto.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(myPhoto.FileName);
                        var path = Path.Combine(Server.MapPath("~/Downloads"), fileName);
                        myPhoto.SaveAs(path);
                        kep = System.IO.File.ReadAllBytes(path);
                    }

                    using (var bl = new BusinessLogic.LogicClient())
                    {

                        bl.InsertingProcesszorDB(processzor.Gyarto, processzor.ProcFoglalatID, megnev, ar1, db1, magok1, frekvencia1, kep);
                    }
                    return View();
                }
            }
            else
            {
                using (var bl = new BusinessLogic.LogicClient())
                {
                    var gyarto = bl.GyartoGet();
                    processzor.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                    processzor.ProcFoglalatList = new SelectList(bl.ProcesszorGet(), "ID", "Megnevezes");

                }
                return View("CPUInserting", processzor);
            }
        }


        public ActionResult SzamitogephazInsertSave(string megnev, string ar, string db, SzamitogephazViewModel haz, HttpPostedFileBase myPhoto)
        {
            if (ModelState.IsValid)
            {
                if (myPhoto == null)
                {
                    ModelState.AddModelError("Kep", "Kép megadása kötelező!");

                    using (var bl = new BusinessLogic.LogicClient())
                    {
                        var gyarto = bl.GyartoGet();
                        haz.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                        
                    }
                    return View("SzamitogephazInserting", haz);
                }
                else
                {
                    int ar1 = Int32.Parse(ar);
                    int db1 = Int32.Parse(db);

                    byte[] kep = null;
                    if (myPhoto != null && myPhoto.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(myPhoto.FileName);
                        var path = Path.Combine(Server.MapPath("~/Downloads"), fileName);
                        myPhoto.SaveAs(path);
                        kep = System.IO.File.ReadAllBytes(path);
                    }

                    using (var bl = new BusinessLogic.LogicClient())
                    {

                        bl.InsertingSzamitogephazDB( haz.Gyarto, megnev, ar1, db1, kep);
                    }
                    return View();
                }
            }
            else
            {
                using (var bl = new BusinessLogic.LogicClient())
                {
                    var gyarto = bl.GyartoGet();
                    haz.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");

                }
                return View("SzamitogephazInserting", haz);
            }
        }

        public ActionResult TapegysegInsertSave(string megnev, string ar, string db, string telj, TapegysegViewModel tap, HttpPostedFileBase myPhoto)
        {
            if (ModelState.IsValid)
            {
                if (myPhoto == null)
                {
                    ModelState.AddModelError("Kep", "Kép megadása kötelező!");

                    using (var bl = new BusinessLogic.LogicClient())
                    {
                        var gyarto = bl.GyartoGet();
                        tap.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");

                    }
                    return View("TapegysegInserting", tap);
                }
                else
                {
                    int ar1 = Int32.Parse(ar);
                    int db1 = Int32.Parse(db);
                    int telj1 = Int32.Parse(telj);

                    byte[] kep = null;
                    if (myPhoto != null && myPhoto.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(myPhoto.FileName);
                        var path = Path.Combine(Server.MapPath("~/Downloads"), fileName);
                        myPhoto.SaveAs(path);
                        kep = System.IO.File.ReadAllBytes(path);
                    }

                    using (var bl = new BusinessLogic.LogicClient())
                    {

                        bl.InsertingTapegysegDB(tap.Gyarto, megnev, ar1, db1, telj1, kep);
                    }
                    return View();
                }
            }
            else
            {
                using (var bl = new BusinessLogic.LogicClient())
                {
                    var gyarto = bl.GyartoGet();
                    tap.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");

                }
                return View("TapegysegInserting", tap);
            }
        }

        public ActionResult VideokartyaInsertSave(string mondb, string megnev, string ar, string db, string meret, VideokartyaViewModel vid, HttpPostedFileBase myPhoto)
        {
            if (ModelState.IsValid)
            {
                if (myPhoto == null)
                {
                    ModelState.AddModelError("Kep", "Kép megadása kötelező!");

                    using (var bl = new BusinessLogic.LogicClient())
                    {
                        var gyarto = bl.GyartoGet();
                        vid.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                        vid.MemoriaTipusList = new SelectList(bl.MemoriaGet(), "ID", "Megnevezes");
                        vid.MonitorCsatoloList = new SelectList(bl.MonitorCsatoloTipusGet(), "ID", "Megnevezes");

                    }
                    return View("VideokartyaInserting", vid);
                }
                else
                {
                    int ar1 = Int32.Parse(ar);
                    int db1 = Int32.Parse(db);
                    int meret1 = Int32.Parse(meret);
                    int mondb1 = Int32.Parse(mondb);

                    byte[] kep = null;
                    if (myPhoto != null && myPhoto.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(myPhoto.FileName);
                        var path = Path.Combine(Server.MapPath("~/Downloads"), fileName);
                        myPhoto.SaveAs(path);
                        kep = System.IO.File.ReadAllBytes(path);
                    }

                    using (var bl = new BusinessLogic.LogicClient())
                    {

                        bl.InsertingVideokartyaDB(vid.MonitorCsatoloID, mondb1, vid.Gyarto, vid.MemoriaTipusID, megnev, ar1, db1, meret1, kep);
                    }
                    return View();
                }
            }
            else
            {
                using (var bl = new BusinessLogic.LogicClient())
                {
                    var gyarto = bl.GyartoGet();
                    vid.AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes");
                    vid.MemoriaTipusList = new SelectList(bl.MemoriaGet(), "ID", "Megnevezes");
                    vid.MonitorCsatoloList = new SelectList(bl.MonitorCsatoloTipusGet(), "ID", "Megnevezes");
                }
                return View("VideokartyaInserting", vid);
            }
        }

        public ActionResult AlaplapEditSave(string megnev, string usbdb, string hatdb, string ar, string db, string vgadb, string memdb, AlaplapViewModel alaplap)
        {           
            int ar1 = Int32.Parse(ar);
            int db1 = Int32.Parse(db);
            int vgadb1 = Int32.Parse(vgadb);
            int memdb1 = Int32.Parse(memdb);
            int usbdb1 = Int32.Parse(usbdb);
            int hatdb1 = Int32.Parse(hatdb);
            using (var bl = new BusinessLogic.LogicClient())
            {
                bl.InsertAlaplap(alaplap.HattertarCsatoloID, alaplap.USBID, usbdb1, hatdb1, alaplap.ID, alaplap.Gyarto, alaplap.FoglalatID, alaplap.MemoriaFoglalatID, alaplap.VGAID, alaplap.PCIID, memdb1, vgadb1, alaplap.IsPs2, megnev, ar1, db1);
            }
            return View();
        }

        public ActionResult MonitorEditSave(string megnev, string ar, string db, MonitorViewModel monitor)
        {
            int ar1 = Int32.Parse(ar);
            int db1 = Int32.Parse(db);
            using (var bl = new BusinessLogic.LogicClient())
            {
                bl.InsertMonitor(monitor.ID, monitor.Gyarto, monitor.CsatoloID, monitor.FelbontasID, monitor.MeretID, megnev, ar1, db1);
            }
            return View("AlaplapEditSave");
        }

        public ActionResult BillentyuzetEditSave(string megnev, string ar, string db, BillentyuzetViewModel billentyuzet)
        {
            int ar1 = Int32.Parse(ar);
            int db1 = Int32.Parse(db);
            using (var bl = new BusinessLogic.LogicClient())
            {
                bl.InsertBillentyuzet(billentyuzet.ID, billentyuzet.Gyarto, billentyuzet.UsbID, billentyuzet.IsPs2, megnev, ar1, db1);
            }
            return View("AlaplapEditSave");
        }

        public ActionResult CPUEditSave(string megnev, string ar, string db, string magok, string frek, ProcesszorViewModel processzor)
        {
            int ar1 = Int32.Parse(ar);
            int db1 = Int32.Parse(db);
            int magok1 = Int32.Parse(magok);
            int frek1 = Int32.Parse(frek);
            using (var bl = new BusinessLogic.LogicClient())
            {
                bl.InsertCPU(processzor.ID, processzor.Gyarto, processzor.ProcFoglalatID, megnev, ar1, db1, magok1, frek1);
            }
            return View("AlaplapEditSave");
        }

        public ActionResult EgerEditSave(string megnev, string ar, string db, EgerViewModel eger)
        {
            int ar1 = Int32.Parse(ar);
            int db1 = Int32.Parse(db);
            using (var bl = new BusinessLogic.LogicClient())
            {
                bl.InsertEger(eger.ID, eger.Gyarto, eger.UsbID, eger.IsPs2, megnev, ar1, db1);
            }
            return View("AlaplapEditSave");
        }

        public ActionResult SzamitogephazEditSave(string megnev, string ar, string db, SzamitogephazViewModel haz)
        {
            int ar1 = Int32.Parse(ar);
            int db1 = Int32.Parse(db);
            using (var bl = new BusinessLogic.LogicClient())
            {
                bl.InsertSzamitogephaz(haz.ID, haz.Gyarto, megnev, ar1, db1);
            }
            return View("AlaplapEditSave");
        }

        public ActionResult TapegysegEditSave(string megnev, string ar, string db, string telj, TapegysegViewModel tap)
        {
            int ar1 = Int32.Parse(ar);
            int db1 = Int32.Parse(db);
            int telj1 = Int32.Parse(telj);
            using (var bl = new BusinessLogic.LogicClient())
            {
                bl.InsertTapegyseg(tap.ID, tap.Gyarto, megnev, ar1, db1, telj1);
            }
            return View("AlaplapEditSave");
        }

        public ActionResult VideokartyaEditSave(string megnev, string mondb, string ar, string db, string meret, VideokartyaViewModel vid)
        {
            int ar1 = Int32.Parse(ar);
            int db1 = Int32.Parse(db);
            int meret1 = Int32.Parse(meret);
            int mondb1 = Int32.Parse(mondb);
            using (var bl = new BusinessLogic.LogicClient())
            {
                bl.InsertVideokartya(vid.MonitorCsatoloID, mondb1, vid.ID, vid.Gyarto, vid.MemoriaTipusID, megnev, ar1, db1, meret1);
            }
            return View("AlaplapEditSave");
        }

        public ActionResult HattertarEditSave(string megnev, string ar, string db, string meret, HattertarViewModel hat)
        {
            int ar1 = Int32.Parse(ar);
            int db1 = Int32.Parse(db);
            int meret1 = Int32.Parse(meret);
            using (var bl = new BusinessLogic.LogicClient())
            {
                bl.InsertHattertar(hat.ID, hat.Gyarto, hat.CsatoloID, hat.TipusID, megnev, ar1, db1, meret1);
            }
            return View("AlaplapEditSave");
        }

        public ActionResult MemoriaEditSave(string megnev, string ar, string db, string meret, MemoriaViewModel mem)
        {
            int ar1 = Int32.Parse(ar);
            int db1 = Int32.Parse(db);
            int meret1 = Int32.Parse(meret);
            using (var bl = new BusinessLogic.LogicClient())
            {
                bl.InsertMemoria(mem.ID, mem.Gyarto, mem.FoglalatID, megnev, ar1, db1, meret1);
            }
            return View("AlaplapEditSave");
        }

        public ActionResult AlaplapEdit(string id)
        {
            AlaplapViewModel alaplap;
            int id1=Int32.Parse(id);
            
            using (var bl = new BusinessLogic.LogicClient())
            {     
                var gyarto=bl.GyartoGet();
                var model = bl.Alaplap_GetByID(id1);
                var modelusb = bl.USBGetByAlaplapID(id1);
                var modelhatter = bl.HattertarGetByAlaplapID(id1);
                AlkatreszGyarto gyarto2 = bl.Gyarto_GetByName(model.Gyarto).Single();
                int gyartoid = gyarto2.ID;
                alaplap = new AlaplapViewModel
                {
                    ID = model.ID,
                    Db = model.Db,
                    FoglalatID = model.FoglalatID,
                    Foglalat = model.Foglalat,
                    MemoriaDarab = model.MemoriaDarab,
                    MemoriaFoglalatID = model.MemoriaFoglalatID,
                    Megnevezes = model.Megnevezes,
                    MemoriaFoglalat = model.MemoriaFoglalat,
                    VGADarab = model.VGADarab,
                    Gyarto = gyartoid,
                    IsPs2 = model.IsPs2,
                    Kep = model.Kep,
                    NettoAr = model.NettoAr,
                    VGA=model.VGA,
                    VGAID=model.VGAID,
                    PCI=model.PCI,
                    PCIID=model.PCIID,
                    USBdb=modelusb.Darab,
                    USBID=(Int32)modelusb.USB_ID,
                    Hattertardb=modelhatter.Darab,
                    HattertarCsatoloID=(Int32)modelhatter.Csatolo_ID,
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),
                    ProcFoglalat=new SelectList(bl.ProcesszorGet(), "ID", "Megnevezes" ),
                    MemoriaFoglalatList=new SelectList(bl.MemoriaGet(), "ID", "Megnevezes"),
                    VGACsatolo=new SelectList(bl.VgaGet(), "ID", "Megnevezes"),
                    PCIExpressz=new SelectList(bl.PciGet(), "ID", "Megnevezes"),
                    USBList=new SelectList(bl.UsbGet(), "ID", "Megnevezes"),
                    HattertarCsatoloList=new SelectList(bl.HattertarCsatoloTipusGet(), "ID", "Megnevezes")
                };
               
            }
            return View(alaplap);
        }

        public ActionResult MonitorEdit(string id)
        {
            MonitorViewModel mon;
            int id1 = Int32.Parse(id);

            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                var model = bl.Monitor_GetByID(id1);
                AlkatreszGyarto gyarto2 = bl.Gyarto_GetByName(model.Gyarto).Single();
                int gyartoid = gyarto2.ID;
                mon = new MonitorViewModel
                {
                    ID = model.ID,
                    Db = model.Db,
                    Megnevezes = model.Megnevezes,
                    Gyarto = gyartoid,
                    Kep = model.Kep,
                    NettoAr = model.NettoAr,
                    Csatolo=model.Csatolo,
                    CsatoloID=model.CsatoloID,
                    Felbontas=model.Felbontas,
                    FelbontasID=model.FelbontasID,
                    Meret=model.Meret,
                    MeretID=model.MeretID,
                    MonitorCsatolo=new SelectList(bl.MonitorCsatoloTipusGet(), "ID", "Megnevezes"),
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),
                    MonitorFelbontas=new SelectList(bl.MonitorFelbontasGet(), "ID", "Megnevezes"),
                    MonitorMeret=new SelectList(bl.MonitorMeretGet(), "ID", "Megnevezes")
                };

            }
            return View(mon);
        }

        public ActionResult BillentyuzetEdit(string id)
        {
            BillentyuzetViewModel billentyuzet;
            int id1 = Int32.Parse(id);

            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                var model = bl.Billentyuzet_GetByID(id1);
                AlkatreszGyarto gyarto2 = bl.Gyarto_GetByName(model.Gyarto).Single();
                int gyartoid = gyarto2.ID;
                billentyuzet = new BillentyuzetViewModel
                {
                    ID = model.ID,
                    Db = model.Db,
                    Megnevezes = model.Megnevezes,
                    Gyarto = gyartoid,
                    IsPs2 = model.IsPs2,
                    Kep = model.Kep,
                    NettoAr = model.NettoAr,
                    Usb=model.Usb,
                    UsbID=model.UsbID,
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),
                    USBList=new SelectList(bl.UsbGet(), "id", "megnevezes")
                };

            }
            return View(billentyuzet);
        }

        public ActionResult SzamitogephazEdit(string id)
        {
            SzamitogephazViewModel haz;
            int id1 = Int32.Parse(id);

            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                var model = bl.Szamitogephaz_GetByID(id1);
                AlkatreszGyarto gyarto2 = bl.Gyarto_GetByName(model.Gyarto).Single();
                int gyartoid = gyarto2.ID;
                haz = new SzamitogephazViewModel
                {
                    ID = model.ID,
                    Db = model.Db,
                    Megnevezes = model.Megnevezes,
                    Gyarto = gyartoid,
                    Kep = model.Kep,
                    NettoAr = model.NettoAr,
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes")

                };

            }
            return View(haz);
        }

        public ActionResult TapegysegEdit(string id)
        {
            TapegysegViewModel tap;
            int id1 = Int32.Parse(id);

            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                var model = bl.Tapegyseg_GetByID(id1);
                AlkatreszGyarto gyarto2 = bl.Gyarto_GetByName(model.Gyarto).Single();
                int gyartoid = gyarto2.ID;
                tap = new TapegysegViewModel
                {
                    ID = model.ID,
                    Db = model.Db,
                    Megnevezes = model.Megnevezes,
                    Gyarto = gyartoid,
                    Kep = model.Kep,
                    NettoAr = model.NettoAr,
                    Teljesitmeny=model.Teljesitmeny,
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes")

                };

            }
            return View(tap);
        }

        public ActionResult VideokartyaEdit(string id)
        {
            VideokartyaViewModel vid;
            int id1 = Int32.Parse(id);

            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                var model = bl.Videokartya_GetByID(id1);
                var modelvideo = bl.MonitorcsatoloGetByVideokartyaID(id1);
                AlkatreszGyarto gyarto2 = bl.Gyarto_GetByName(model.Gyarto).Single();
                int gyartoid = gyarto2.ID;
                vid = new VideokartyaViewModel
                {
                    ID = model.ID,
                    Db = model.Db,
                    Megnevezes = model.Megnevezes,
                    Gyarto = gyartoid,
                    Kep = model.Kep,
                    NettoAr = model.NettoAr,
                    MemoriaTipus=model.MemoriaTipus,
                    MemoriaTipusID=model.MemoriaTipusID,
                    MemoriaMeret=model.MemoriaMeret,
                    Csatolodb=modelvideo.Darab,
                    MonitorCsatoloID=modelvideo.CsatoloID,
                    MonitorCsatoloList=new SelectList(bl.MonitorCsatoloTipusGet(), "ID", "Megnevezes"),
                    MemoriaTipusList=new SelectList(bl.MemoriaGet(), "ID", "Megnevezes"),
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes")

                };

            }
            return View(vid);
        }

        public ActionResult HattertarEdit(string id)
        {
            HattertarViewModel hattertar;
            int id1 = Int32.Parse(id);

            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                var model = bl.Hattertar_GetByID(id1);
                AlkatreszGyarto gyarto2 = bl.Gyarto_GetByName(model.Gyarto).Single();
                int gyartoid = gyarto2.ID;
                hattertar = new HattertarViewModel
                {
                    ID = model.ID,
                    Db = model.Db,
                    Megnevezes = model.Megnevezes,
                    Gyarto = gyartoid,
                    Kep = model.Kep,
                    Csatolo=model.Csatolo,
                    CsatoloID=model.CsatoloID,
                    Meret=model.Meret,
                    Tipus=model.Tipus,
                    TipusID=model.TipusID,
                    HattertarTipus=new SelectList(bl.HattertarTipusGet(), "ID", "Megnevezes"),
                    HattertarCsatoloTipus=new SelectList(bl.HattertarCsatoloTipusGet(), "ID", "Megnevezes"),
                    NettoAr = model.NettoAr,
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),

                };

            }
            return View(hattertar);
        }

        public ActionResult MemoriaEdit(string id)
        {
            MemoriaViewModel memoria;
            int id1 = Int32.Parse(id);

            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                var model = bl.Memoria_GetByID(id1);
                AlkatreszGyarto gyarto2 = bl.Gyarto_GetByName(model.Gyarto).Single();
                int gyartoid = gyarto2.ID;
                memoria = new MemoriaViewModel
                {
                    ID = model.ID,
                    Db = model.Db,
                    Megnevezes = model.Megnevezes,
                    Gyarto = gyartoid,
                    Kep = model.Kep,
                    NettoAr = model.NettoAr,
                    Foglalat=model.Foglalat,
                    FoglalatID=model.FoglalatID,
                    MemoriaMeret=model.MemoriaMeret,
                    MemoriaFoglalatTipus=new SelectList(bl.MemoriaGet(), "ID", "Megnevezes"),
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),

                };

            }
            return View(memoria);
        }

        public ActionResult CPUEdit(string id)
        {
            ProcesszorViewModel cpu;
            int id1 = Int32.Parse(id);

            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                var model = bl.Processzor_GetByID(id1);
                AlkatreszGyarto gyarto2 = bl.Gyarto_GetByName(model.Gyarto).Single();
                int gyartoid = gyarto2.ID;
                cpu = new ProcesszorViewModel
                {
                    ID = model.ID,
                    Db = model.Db,
                    Megnevezes = model.Megnevezes,
                    Gyarto = gyartoid,
                    Kep = model.Kep,
                    NettoAr = model.NettoAr,
                    Frekvencia=model.Frekvencia,
                    FrekvenciaMertek=model.FrekvenciaMertek,
                    FrekvenciaMertekID=model.FrekvenciaMertekID,
                    Magok=model.Magok,
                    ProcFoglalat=model.ProcFoglalat,
                    ProcFoglalatID=model.ProcFoglalatID,
                    ProcFoglalatList=new SelectList(bl.ProcesszorGet(), "ID", "Megnevezes"),
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),
                };

            }
            return View(cpu);
        }

        public ActionResult EgerEdit(string id)
        {
            EgerViewModel eger;
            int id1 = Int32.Parse(id);

            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                var model = bl.Eger_GetByID(id1);
                AlkatreszGyarto gyarto2 = bl.Gyarto_GetByName(model.Gyarto).Single();
                int gyartoid = gyarto2.ID;
                eger = new EgerViewModel
                {
                    ID = model.ID,
                    Db = model.Db,
                    Megnevezes = model.Megnevezes,
                    Gyarto = gyartoid,
                    IsPs2 = model.IsPs2,
                    Kep = model.Kep,
                    NettoAr = model.NettoAr,
                    Usb = model.Usb,
                    UsbID = model.UsbID,
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),
                    USBList = new SelectList(bl.UsbGet(), "id", "megnevezes")
                };

            }
            return View(eger);
        }

        public ActionResult ProductEdit()
        {
            SessionData.Instance.ShowCategories = false;

            return View();
        }

        public ActionResult ProductInsert()
        {
            SessionData.Instance.ShowCategories = false;
            return View();
        }

        public ActionResult ProductListToEdit(int fokategoria)
        {

            List<Fokategoriatipus> model = new List<Fokategoriatipus>();
            FoKategoria kat = (FoKategoria)fokategoria;

            using (var bl = new BusinessLogic.LogicClient())
            {
                switch (kat)
                {
                    case FoKategoria.Alaplap:
                        Fokategoriatipus[] list = bl.GetAlaplap();
                        foreach (var item in list)
                        {
                            model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Alaplap" });
                        }
                        break;
                    case FoKategoria.Billentyuzet:
                        Fokategoriatipus[] list1 = bl.GetBillentyuzet();
                        foreach (var item in list1)
                        {
                            model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Billentyuzet" });
                        }
                        break;
                    case FoKategoria.Eger:
                        Fokategoriatipus[] list2 = bl.GetEger();
                        foreach (var item in list2)
                        {
                            model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Eger" });
                        }
                        break;
                    case FoKategoria.Hattertar:
                        Fokategoriatipus[] list3 = bl.GetHattertar();
                        foreach (var item in list3)
                        {
                            model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Hattertar" });
                        }
                        break;
                    case FoKategoria.Memoria:
                        Fokategoriatipus[] list4 = bl.GetMemoria();
                        foreach (var item in list4)
                        {
                            model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Memoria" });
                        }
                        break;
                    case FoKategoria.Monitor:
                        Fokategoriatipus[] list5 = bl.GetMonitor();
                        foreach (var item in list5)
                        {
                            model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Monitor" });
                        }
                        break;
                    case FoKategoria.Processzor:
                        Fokategoriatipus[] list6 = bl.GetProcesszor();
                        foreach (var item in list6)
                        {
                            model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Processzor" });
                        }
                        break;
                    case FoKategoria.Szamitogephaz:
                        Fokategoriatipus[] list7 = bl.GetSzamitogephaz();
                        foreach (var item in list7)
                        {
                            model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Szamitogephaz" });
                        }
                        break;
                    case FoKategoria.Tapegyseg:
                        Fokategoriatipus[] list8 = bl.GetTapegyseg();
                        foreach (var item in list8)
                        {
                            model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Tapegyseg" });
                        }
                        break;
                    case FoKategoria.Videokartya:
                        Fokategoriatipus[] list9 = bl.GetVideokartya();
                        foreach (var item in list9)
                        {
                            model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Videokartya" });
                        }
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            return PartialView(model);
        }

        public ActionResult Delete(string id, string tipus)
        {
            int id2 = Int32.Parse(id);
            using (var bl = new BusinessLogic.LogicClient())
            {
                
                switch (tipus)
                {
                    case "Alaplap":
                        bl.DeleteAlaplap(id2);
                        break;
                    case "Billentyuzet":
                        bl.DeleteBillentyuzet(id2);
                        break;
                    case "Eger":
                        bl.DeleteEger(id2);
                        break;
                    case "Hattertar":
                        bl.DeleteHattertar(id2);
                        break;
                    case "Memoria":
                        bl.DeleteMemoria(id2);
                        break;
                    case "Monitor":
                        bl.DeleteMonitor(id2);
                        break;
                    case "Processzor":
                        bl.DeleteProcesszor(id2);
                        break;
                    case "Szamitogephaz":
                        bl.DeleteSzamitogephaz(id2);
                        break;
                    case "Tapegyseg":
                        bl.DeleteTapegyseg(id2);
                        break;
                    case "Videokartya":
                        bl.DeleteVideokartya(id2);
                        break;
                    default:
                        throw new NotImplementedException();
                       
                }
            }

            return View();
        }

        public ActionResult ProductDelete()
        {
            return View();
        }

       

        //public ActionResult ProductInsertByFokat(int fokategoria)
        //{
        //    FoKategoria kat = (FoKategoria)fokategoria;
        //    switch (kat)
        //    {
        //        case FoKategoria.Alaplap:
        //            AlaplapViewModel model=null;
        //            return AlaplapInserting(model);
                  
                   
        //        case FoKategoria.Billentyuzet:
        //            BillentyuzetViewModel model1 = null;
        //            return BillentyuzetInserting(model1);
                   
        //        case FoKategoria.Eger:
        //            EgerViewModel model2 = null;
        //            return EgerInserting(model2);
                    
                   
        //        case FoKategoria.Hattertar:
        //            HattertarViewModel model3 = null;
        //            return HattertarInserting(model3);
                   
        //        case FoKategoria.Memoria:
        //            MemoriaViewModel model4 = null;
        //            return MemoriaInserting(model4);
                  
        //        case FoKategoria.Monitor:
        //            MonitorViewModel model5 = null;
        //            return MonitorInserting(model5);
                   
        //        case FoKategoria.Processzor:
        //            ProcesszorViewModel model6 = null;
        //            return CPUInserting(model6);
                    
        //        case FoKategoria.Szamitogephaz:
        //            SzamitogephazViewModel model7 = null;
        //            return SzamitogephazInserting(model7);
                    
        //        case FoKategoria.Tapegyseg:
        //            TapegysegViewModel model8 = null;
        //            return TapegysegInserting(model8);
                    
        //        case FoKategoria.Videokartya:
        //            VideokartyaViewModel model9 = null;
        //            return VideokartyaInserting(model9);
                    
        //        default:
        //            throw new NotImplementedException();
        //    }

        //}


        public ActionResult AlaplapInserting()
        {

            AlaplapViewModel model;
            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                model = new AlaplapViewModel
                {
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),
                    ProcFoglalat = new SelectList(bl.ProcesszorGet(), "ID", "Megnevezes"),
                    MemoriaFoglalatList = new SelectList(bl.MemoriaGet(), "ID", "Megnevezes"),
                    VGACsatolo = new SelectList(bl.VgaGet(), "ID", "Megnevezes"),
                    PCIExpressz = new SelectList(bl.PciGet(), "ID", "Megnevezes"),
                    USBList = new SelectList(bl.UsbGet(), "ID", "Megnevezes"),
                    HattertarCsatoloList = new SelectList(bl.HattertarCsatoloTipusGet(), "ID", "Megnevezes"),
                };
            }

            return PartialView(model);
        }

        public ActionResult BillentyuzetInserting()
        {
            BillentyuzetViewModel model;
            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                model = new BillentyuzetViewModel
                {
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),
                    USBList=new SelectList(bl.UsbGet(), "id", "megnevezes")
                };
            }

            return PartialView(model);
        }

        public ActionResult EgerInserting()
        {
            EgerViewModel model;
            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                model = new EgerViewModel
                {                   
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),
                    USBList = new SelectList(bl.UsbGet(), "id", "megnevezes")
                };
            }

            return PartialView(model);
        }

        public ActionResult HattertarInserting()
        {
            HattertarViewModel model;
            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                model = new HattertarViewModel
                {
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),
                    HattertarTipus=new SelectList(bl.HattertarTipusGet(), "ID", "Megnevezes"),
                    HattertarCsatoloTipus=new SelectList(bl.HattertarCsatoloTipusGet(), "ID", "Megnevezes")
                };
            }

            return PartialView(model);
        }

        public ActionResult MemoriaInserting()
        {
            MemoriaViewModel model;
            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                model = new MemoriaViewModel
                {
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),
                    MemoriaFoglalatTipus=new SelectList(bl.MemoriaGet(), "ID", "Megnevezes"),
                   
                };
            }

            return PartialView(model);
        }

        public ActionResult MonitorInserting()
        {
            MonitorViewModel model;
            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                model = new MonitorViewModel
                {
                    MonitorCsatolo=new SelectList(bl.MonitorCsatoloTipusGet(), "ID", "Megnevezes"),
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),
                    MonitorFelbontas=new SelectList(bl.MonitorFelbontasGet(), "ID", "Megnevezes"),
                    MonitorMeret=new SelectList(bl.MonitorMeretGet(), "ID", "Megnevezes")
                };
            }

            return PartialView(model);
        }

        public ActionResult CPUInserting()
        {
            ProcesszorViewModel model;
            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                model = new ProcesszorViewModel
                {
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),
                   ProcFoglalatList=new SelectList(bl.ProcesszorGet(), "ID", "Megnevezes"),
                  
                };
            }

            return PartialView(model);
        }

        public ActionResult SzamitogephazInserting()
        {
            SzamitogephazViewModel model;
            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                model = new SzamitogephazViewModel
                {
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),
                   
                };
            }

            return PartialView(model);
        }

        public ActionResult TapegysegInserting()
        {
            TapegysegViewModel model;
            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                model = new TapegysegViewModel
                {
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),
                   
                };
            }

            return PartialView(model);
        }

        public ActionResult VideokartyaInserting()
        {
            VideokartyaViewModel model;
            using (var bl = new BusinessLogic.LogicClient())
            {
                var gyarto = bl.GyartoGet();
                model = new VideokartyaViewModel
                {
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),
                    MemoriaTipusList=new SelectList(bl.MemoriaGet(), "ID", "Megnevezes"),
                    MonitorCsatoloList=new SelectList(bl.MonitorCsatoloTipusGet(), "ID", "Megnevezes")
                   
                };
            }

            return PartialView(model);
        }

        public ActionResult ProductList(int fokategoria)
        {
             List<Fokategoriatipus> model = new List<Fokategoriatipus>();
             FoKategoria kat = (FoKategoria)fokategoria;

             using (var bl = new BusinessLogic.LogicClient())
             {
                 switch (kat)
                 {
                     case FoKategoria.Alaplap:
                         Fokategoriatipus[] list = bl.GetAlaplap();
                         foreach(var item in list){
                             model.Add(new Fokategoriatipus { ID=item.ID, Kep=item.Kep, Megnevezes=item.Megnevezes, Tipus="Alaplap"});
                         }
                         break;
                     case FoKategoria.Billentyuzet:
                         Fokategoriatipus[] list1 = bl.GetBillentyuzet();
                         foreach (var item in list1)
                         {
                             model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Billentyuzet" });
                         }
                         break;
                     case FoKategoria.Eger:
                         Fokategoriatipus[] list2 = bl.GetEger();
                         foreach (var item in list2)
                         {
                             model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Eger" });
                         }
                         break;
                     case FoKategoria.Hattertar:
                         Fokategoriatipus[] list3 = bl.GetHattertar();
                         foreach (var item in list3)
                         {
                             model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Hattertar" });
                         }
                         break;
                     case FoKategoria.Memoria:
                         Fokategoriatipus[] list4 = bl.GetMemoria();
                         foreach (var item in list4)
                         {
                             model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Memoria" });
                         }
                         break;
                     case FoKategoria.Monitor:
                         Fokategoriatipus[] list5 = bl.GetMonitor();
                         foreach (var item in list5)
                         {
                             model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Monitor" });
                         }
                         break;
                     case FoKategoria.Processzor:
                         Fokategoriatipus[] list6 = bl.GetProcesszor();
                         foreach (var item in list6)
                         {
                             model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Processzor" });
                         }
                         break;
                     case FoKategoria.Szamitogephaz:
                         Fokategoriatipus[] list7 = bl.GetSzamitogephaz();
                         foreach (var item in list7)
                         {
                             model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Szamitogephaz" });
                         }
                         break;
                     case FoKategoria.Tapegyseg:
                         Fokategoriatipus[] list8 = bl.GetTapegyseg();
                         foreach (var item in list8)
                         {
                             model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Tapegyseg" });
                         }
                         break;
                     case FoKategoria.Videokartya:
                         Fokategoriatipus[] list9 = bl.GetVideokartya();
                         foreach (var item in list9)
                         {
                             model.Add(new Fokategoriatipus { ID = item.ID, Kep = item.Kep, Megnevezes = item.Megnevezes, Tipus = "Videokartya" });
                         }
                         break;
                     default:
                         throw new NotImplementedException();
                 }
             }
            return PartialView(model);
        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            SessionData.Instance.ShowCategories = false;

            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(CreateCategoryViewModel model)
        {
            using (var bl = new BusinessLogic.LogicClient())
            {
                Kategoriak kat = model.Tipus;

                switch (kat)
                {
                    case Kategoriak.AlkatreszGyarto:
                        var gyartoToUpdate = new AlkatreszGyarto
                        {
                            Megnevezes = model.Megnevezes,
                        };

                        bl.Gyarto_Add(gyartoToUpdate);
                        break;
                    case Kategoriak.HattertarCsatoloTipus:
                        var hatterCsatoloToUpdate = new HattertarCsatoloTipus
                        {
                            Megnevezes = model.Megnevezes
                        };

                        bl.HattertatCsatoloTipus_Add(hatterCsatoloToUpdate);
                        break;
                    case Kategoriak.HattertarTipus:
                        var hatterTipusToUpdate = new HattertarTipus
                        {
                            Megnevezes = model.Megnevezes,
                        };

                        bl.HattertatTipus_Add(hatterTipusToUpdate);
                        break;
                    case Kategoriak.MemoriaFoglalat:
                        var memoriaToUpdate = new MemoriaTipus
                        {
                            Megnevezes = model.Megnevezes,
                        };


                        bl.MemoriaFoglalat_Add(memoriaToUpdate);
                        break;
                    case Kategoriak.MonitorFelbontas:
                        var monitorFelbontasToUpdate = new MonitorFelbontas
                        {
                            Megnevezes = model.Megnevezes,
                        };

                        bl.MonitorFelbontasTipus_Add(monitorFelbontasToUpdate);
                        break;
                    case Kategoriak.MonitorMeret:
                        var monitorMeretToUpdate = new MonitorMeret
                        {
                            Megnevezes = model.Megnevezes,
                        };

                        bl.MonitorMeretTipus_Add(monitorMeretToUpdate);
                        break;
                    case Kategoriak.PciExpress:
                        var pciToUpdate = new PciExpressTipus
                        {
                            Megnevezes = model.Megnevezes,
                        };

                        bl.PCIExpress_Add(pciToUpdate);
                        break;
                    case Kategoriak.ProcFoglalat:
                        var procFoglalatToUpdate = new ProcesszorFoglalatTipus
                        {
                            Megnevezes = model.Megnevezes,
                        };

                        bl.ProcFoglalat_Add(procFoglalatToUpdate);
                        break;
                    case Kategoriak.USB:
                        var usbToUpdate = new UsbTipus
                        {
                            Megnevezes = model.Megnevezes,
                        };

                        bl.UsbTipus_Add(usbToUpdate);
                        break;
                    case Kategoriak.VGACsatolo:
                        var vgaToUpdate = new VgaCsatoloFeluletTipus
                        {
                            Megnevezes = model.Megnevezes,
                        };

                        bl.VgaCsatolo_Add(vgaToUpdate);
                        break;
                    case Kategoriak.MonitorCsatolo:
                        var monitorCsatoloToUpdate = new MonitorCsatoloTipus
                        {
                            Megnevezes = model.Megnevezes,
                        };

                        bl.MonitorCsatolo_Add(monitorCsatoloToUpdate);
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

            return RedirectToAction("CreateCategory");
        }

        [HttpGet]
        public ActionResult EditCategory(int id, int type)
        {
            Kategoriak kat = (Kategoriak)type;

            AlkatreszTipus tipus = null;
            using (var bl = new BusinessLogic.LogicClient())
            {
                switch (kat)
                {
                    case Kategoriak.AlkatreszGyarto:
                        tipus = bl.Gyarto_GetByID(id);
                    break;
                    case Kategoriak.HattertarCsatoloTipus:
                        tipus = bl.HattertatCsatoloTipus_GetKategoriaByID(id);
                        break;
                    case Kategoriak.HattertarTipus:
                        tipus = bl.HattertatTipus_GetKategoriaByID(id);
                        break;
                    case Kategoriak.MemoriaFoglalat:
                        tipus = bl.MemoriaFoglalat_GetKategoriaByID(id);
                        break;
                    case Kategoriak.MonitorFelbontas:
                        tipus = bl.MonitorFelbontasTipus_GetKategoriaByID(id);
                        break;
                    case Kategoriak.MonitorMeret:
                        tipus = bl.MonitorMeretTipus_GetKategoriaByID(id);
                        break;
                    case Kategoriak.PciExpress:
                        tipus = bl.PCIExpress_GetByID(id);
                        break;
                    case Kategoriak.ProcFoglalat:
                        tipus = bl.ProcesszorFoglalat_GetByID(id);
                        break;
                    case Kategoriak.USB:
                        tipus = bl.UsbTipus_GetKategoriaByID(id);
                        break;
                    case Kategoriak.VGACsatolo:
                        tipus = bl.VgaCsatolo_GetByID(id);
                        break;
                    case Kategoriak.MonitorCsatolo:
                        tipus = bl.MonitorCsatolo_GetByID(id);
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

            return View(model: tipus);
        }

        [HttpPost]
        public ActionResult EditCategory(AlkatreszTipus model)
        {
            using (var bl = new BusinessLogic.LogicClient())
            {
                Kategoriak kat = model.Tipus;

                switch (kat)
                {
                    case Kategoriak.AlkatreszGyarto:
                        var gyartoToUpdate = new AlkatreszGyarto
                        {
                            Megnevezes = model.Megnevezes,
                            ID = model.ID
                        };

                        bl.Gyarto_Update(gyartoToUpdate);
                        break;
                    case Kategoriak.HattertarCsatoloTipus:
                        var hatterCsatoloToUpdate = new HattertarCsatoloTipus
                        {
                            Megnevezes = model.Megnevezes,
                            ID = model.ID
                        };

                        bl.HattertatCsatoloTipus_Update(hatterCsatoloToUpdate);
                        break;
                    case Kategoriak.HattertarTipus:
                        var hatterTipusToUpdate = new HattertarTipus
                        {
                            Megnevezes = model.Megnevezes,
                            ID = model.ID
                        };

                        bl.HattertatTipus_Update(hatterTipusToUpdate);
                        break;
                    case Kategoriak.MemoriaFoglalat:
                        var memoriaToUpdate = new MemoriaTipus
                        {
                            Megnevezes = model.Megnevezes,
                            ID = model.ID
                        };


                        bl.MemoriaFoglalat_Update(memoriaToUpdate);
                        break;
                    case Kategoriak.MonitorFelbontas:
                        var monitorFelbontasToUpdate = new MonitorFelbontas
                        {
                            Megnevezes = model.Megnevezes,
                            ID = model.ID
                        };

                        bl.MonitorFelbontasTipus_Update(monitorFelbontasToUpdate);
                        break;
                    case Kategoriak.MonitorMeret:
                        var monitorMeretToUpdate = new MonitorMeret
                        {
                            Megnevezes = model.Megnevezes,
                            ID = model.ID
                        };

                        bl.MonitorMeretTipus_Update(monitorMeretToUpdate);
                        break;
                    case Kategoriak.PciExpress:
                        var pciToUpdate = new PciExpressTipus
                        {
                            Megnevezes = model.Megnevezes,
                            ID = model.ID
                        };

                        bl.PCIExpress_Update(pciToUpdate);
                        break;
                    case Kategoriak.ProcFoglalat:
                        var procFoglalatToUpdate = new ProcesszorFoglalatTipus
                        {
                            Megnevezes = model.Megnevezes,
                            ID = model.ID
                        };

                        bl.ProcFoglalat_Update(procFoglalatToUpdate);
                        break;
                    case Kategoriak.USB:
                        var usbToUpdate = new UsbTipus
                        {
                            Megnevezes = model.Megnevezes,
                            ID = model.ID
                        };

                        bl.UsbTipus_Update(usbToUpdate);
                        break;
                    case Kategoriak.VGACsatolo:
                        var vgaToUpdate = new VgaCsatoloFeluletTipus
                        {
                            Megnevezes = model.Megnevezes,
                            ID = model.ID
                        };

                        bl.VgaCsatolo_Update(vgaToUpdate);
                        break;
                    case Kategoriak.MonitorCsatolo:
                        var monitorCsatoloToUpdate = new MonitorCsatoloTipus
                        {
                            Megnevezes = model.Megnevezes,
                            ID = model.ID
                        };

                        bl.MonitorCsatolo_Update(monitorCsatoloToUpdate);
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

            return RedirectToAction("EditCategories");
        }

        public ActionResult EditCategories()
        {
            SessionData.Instance.ShowCategories = false;

            return View();
        }

        public ActionResult GetCategories(int kategoria, string text)
        {

            List<AlkatreszTipus> model = new List<AlkatreszTipus>();

            Kategoriak kat = (Kategoriak)kategoria;

            using (var bl = new BusinessLogic.LogicClient())
            {
                switch (kat)
                {
                    case Kategoriak.AlkatreszGyarto:
                        model.AddRange(bl.Gyarto_GetByName(text));
                        break;
                    case Kategoriak.HattertarCsatoloTipus:
                        model.AddRange(bl.HattertatCsatoloTipus_GetKaegoriakByName(text));
                        break;
                    case Kategoriak.HattertarTipus:
                        model.AddRange(bl.HattertatTipus_GetKaegoriakByName(text));
                        break;
                    case Kategoriak.MemoriaFoglalat:
                        model.AddRange(bl.MemoriaFoglalat_GetKaegoriakByName(text));
                        break;
                    case Kategoriak.MonitorFelbontas:
                        model.AddRange(bl.MonitorFelbontasTipus_GetKaegoriakByName(text));
                        break;
                    case Kategoriak.MonitorMeret:
                        model.AddRange(bl.MonitorMeretTipus_GetKaegoriakByName(text));
                        break;
                    case Kategoriak.PciExpress:
                        model.AddRange(bl.PCIExpress_GetByName(text));
                        break;
                    case Kategoriak.ProcFoglalat:
                        model.AddRange(bl.ProcesszorFoglalat_GetByName(text));
                        break;
                    case Kategoriak.USB:
                        model.AddRange(bl.UsbTipus_GetKaegoriakByName(text));
                        break;
                    case Kategoriak.VGACsatolo:
                        model.AddRange(bl.VgaCsatolo_GetByName(text));
                        break;
                    case Kategoriak.MonitorCsatolo:
                        model.AddRange(bl.MonitorCsatolo_GetByName(text));
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            return PartialView(model);
        }

        public ActionResult DeleteCategory()
        {
            SessionData.Instance.ShowCategories = false;

            return View();
        }

        public ActionResult GetCategoriesForDelete(int kategoria, string text)
        {
            List<AlkatreszTipus> model = new List<AlkatreszTipus>();

            Kategoriak kat = (Kategoriak)kategoria;

            using (var bl = new BusinessLogic.LogicClient())
            {
                switch (kat)
                {
                    case Kategoriak.AlkatreszGyarto:
                        model.AddRange(bl.Gyarto_GetByName(text));
                        break;
                    case Kategoriak.HattertarCsatoloTipus:
                        model.AddRange(bl.HattertatCsatoloTipus_GetKaegoriakByName(text));
                        break;
                    case Kategoriak.HattertarTipus:
                        model.AddRange(bl.HattertatTipus_GetKaegoriakByName(text));
                        break;
                    case Kategoriak.MemoriaFoglalat:
                        model.AddRange(bl.MemoriaFoglalat_GetKaegoriakByName(text));
                        break;
                    case Kategoriak.MonitorFelbontas:
                        model.AddRange(bl.MonitorFelbontasTipus_GetKaegoriakByName(text));
                        break;
                    case Kategoriak.MonitorMeret:
                        model.AddRange(bl.MonitorMeretTipus_GetKaegoriakByName(text));
                        break;
                    case Kategoriak.PciExpress:
                        model.AddRange(bl.PCIExpress_GetByName(text));
                        break;
                    case Kategoriak.ProcFoglalat:
                        model.AddRange(bl.ProcesszorFoglalat_GetByName(text));
                        break;
                    case Kategoriak.USB:
                        model.AddRange(bl.UsbTipus_GetKaegoriakByName(text));
                        break;
                    case Kategoriak.VGACsatolo:
                        model.AddRange(bl.VgaCsatolo_GetByName(text));
                        break;
                    case Kategoriak.MonitorCsatolo:
                        model.AddRange(bl.MonitorCsatolo_GetByName(text));
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            return PartialView(model);
        }

        public ActionResult DeleteCategoryConcrete(int id, int type)
        {
            Kategoriak kat = (Kategoriak)type;

            using (var bl = new BusinessLogic.LogicClient())
            {
                switch (kat)
                {
                    case Kategoriak.AlkatreszGyarto:
                        bl.Gyarto_Delete(id);
                        break;
                    case Kategoriak.HattertarCsatoloTipus:
                        bl.HattertatCsatoloTipus_Delete(id);
                        break;
                    case Kategoriak.HattertarTipus:
                        bl.HattertarTipus_Delete(id);
                        break;
                    case Kategoriak.MemoriaFoglalat:
                        bl.MemoriaFoglalat_Delete(id);
                        break;
                    case Kategoriak.MonitorFelbontas:
                        bl.MonitorFelbontasTipus_Delete(id);
                        break;
                    case Kategoriak.MonitorMeret:
                        bl.MonitorMeretTipus_Delete(id);
                        break;
                    case Kategoriak.PciExpress:
                        bl.PCIExpress_Delete(id);
                        break;
                    case Kategoriak.ProcFoglalat:
                        bl.ProcesszorFoglalat_Delete(id);
                        break;
                    case Kategoriak.USB:
                        bl.UsbTipus_Delete(id);
                        break;
                    case Kategoriak.VGACsatolo:
                        bl.VgaCsatolo_Delete(id);
                        break;
                    case Kategoriak.MonitorCsatolo:
                        bl.MonitorCsatolo_Delete(id);
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

            return View("DeleteCategory");
        }
    }
}