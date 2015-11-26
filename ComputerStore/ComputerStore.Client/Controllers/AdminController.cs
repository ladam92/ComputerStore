using ComputerStore.Client.Models;
using ComputerStore.Client.Utils;
using ComputerStore.DTO.Enums;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
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

        public ActionResult AlaplapEditSave(string megnev, string ar, string db, string vgadb, string memdb, AlaplapViewModel alaplap)
        {           
            int ar1 = Int32.Parse(ar);
            int db1 = Int32.Parse(db);
            int vgadb1 = Int32.Parse(vgadb);
            int memdb1 = Int32.Parse(memdb);
            using (var bl = new BusinessLogic.LogicClient())
            {
                bl.InsertAlaplap(alaplap.ID, alaplap.Gyarto, alaplap.FoglalatID, alaplap.MemoriaFoglalatID, alaplap.VGAID, alaplap.PCIID, memdb1, vgadb1, alaplap.IsPs2, megnev, ar1, db1);
            }
            return View();
        }

        //public ActionResult BillentyuzetEditSave(string megnev, string ar, string db, string vgadb, string memdb, BillentyuzetViewModel billentyuzet)
        //{
        //    int ar1 = Int32.Parse(ar);
        //    int db1 = Int32.Parse(db);
        //    int vgadb1 = Int32.Parse(vgadb);
        //    int memdb1 = Int32.Parse(memdb);
        //    using (var bl = new BusinessLogic.LogicClient())
        //    {
        //        bl.InsertAlaplap(alaplap.ID, alaplap.Gyarto, alaplap.FoglalatID, alaplap.MemoriaFoglalatID, alaplap.VGAID, alaplap.PCIID, memdb1, vgadb1, alaplap.IsPs2, megnev, leiras, ar1, db1);
        //    }
        //    return View();
        //}

        public ActionResult AlaplapEdit(string id)
        {
            AlaplapViewModel alaplap;
            int id1=Int32.Parse(id);
            
            using (var bl = new BusinessLogic.LogicClient())
            {     
                var gyarto=bl.GyartoGet();
                var model = bl.Alaplap_GetByID(id1);
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
                    Leiras = model.Leiras,
                    NettoAr = model.NettoAr,
                    VGA=model.VGA,
                    VGAID=model.VGAID,
                    PCI=model.PCI,
                    PCIID=model.PCIID,
                    AlkatreszGyarto = new SelectList(gyarto, "ID", "Megnevezes"),
                    ProcFoglalat=new SelectList(bl.ProcesszorGet(), "ID", "Megnevezes" ),
                    MemoriaFoglalatList=new SelectList(bl.MemoriaGet(), "ID", "Megnevezes"),
                    VGACsatolo=new SelectList(bl.VgaGet(), "ID", "Megnevezes"),
                    PCIExpressz=new SelectList(bl.PciGet(), "ID", "Megnevezes")

                };
               
            }
            return View(alaplap);
        }

        public ActionResult ProductEdit()
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
    }
}