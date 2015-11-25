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