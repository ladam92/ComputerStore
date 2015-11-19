using ComputerStore.DAL;
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CoputerStore.BL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    public class Logic : ILogic
    {
        public void alma()
        {

        }

        public List<ProcesszorFoglalatTipus> ProcFoglalat_GetKategoriak()
        {
            List<ProcesszorFoglalatTipus> ret = new List<ProcesszorFoglalatTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.proc_foglalat_tipus)
                {
                    ret.Add(new ProcesszorFoglalatTipus
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return ret;
        }

        public List<MemoriaTipus> MemoriaFoglalat_GetKaegoriak()
        {
            List<MemoriaTipus> ret = new List<MemoriaTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.memoria_foglalat_tipus)
                {
                    ret.Add(new MemoriaTipus
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return ret;
        }

        public List<UsbTipus> UsbTipus_GetKaegoriak()
        {
            List<UsbTipus> ret = new List<UsbTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.usb_tipus)
                {
                    ret.Add(new UsbTipus
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return ret;
        }

        public List<HattertarTipus> HattertatTipus_GetKaegoriak()
        {
            List<HattertarTipus> ret = new List<HattertarTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.hattertar_tipus)
                {
                    ret.Add(new HattertarTipus
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return ret;
        }

        public List<HattertarCsatoloTipus> HattertatCsatoloTipus_GetKaegoriak()
        {
            List<HattertarCsatoloTipus> ret = new List<HattertarCsatoloTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.hattertarolo_csatolo_tipus)
                {
                    ret.Add(new HattertarCsatoloTipus
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return ret;
        }

        public List<MonitorFelbontas> MonitorFelbontasTipus_GetKaegoriak()
        {
            List<MonitorFelbontas> ret = new List<MonitorFelbontas>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.monitor_felbontas)
                {
                    ret.Add(new MonitorFelbontas
                    {
                        ID = item.id,
                        Megnevezes = item.felbontás
                    });
                }
            }

            return ret;
        }

        public List<MonitorMeret> MonitorMeretTipus_GetKaegoriak()
        {
            List<MonitorMeret> ret = new List<MonitorMeret>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.monitor_meret)
                {
                    ret.Add(new MonitorMeret
                    {
                        ID = item.id,
                        Megnevezes = item.meret
                    });
                }
            }

            return ret;
        }

        public PageableList<Alaplap> Alaplap_GetByFoglalatID(int id, int pageNumber, int pageSize)
        {
            List<Alaplap> list = new List<Alaplap>();
            int maxNumber = 0;

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.alaplap.Where(i => i.proc_foglalat_tipus_id == id).OrderBy(i => i.megnevezes).Skip((pageNumber - 1) * pageSize).Take(pageSize);

                foreach (var item in query)
                {
                    list.Add(new Alaplap
                    {
                        ID = item.id,
                        FoglalatID = id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        IsPs2 = item.van_ps2_port,
                        Kep = item.kepek.kep,
                        Leiras = item.leiras,
                        Megnevezes = item.megnevezes,
                        MemoriaDarab = item.memoria_foglalat_darab,
                        MemoriaFoglalat = item.memoria_foglalat_tipus.megnevezes,
                        MemoriaFoglalatID = item.memoria_foglalat_tipus_id,
                        NettoAr = item.netto_ar,
                        VGADarab = item.vga_csatolo_darab
                    });
                }

                maxNumber = query.Count();
            }




            return new PageableList<Alaplap>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }

        public PageableList<Alaplap> Alaplap_GetByMemoriaID(int id, int pageNumber, int pageSize)
        {
            List<Alaplap> list = new List<Alaplap>();
            int maxNumber = 0;

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.alaplap.Where(i => i.memoria_foglalat_tipus_id== id).OrderBy(i => i.megnevezes).Skip((pageNumber - 1) * pageSize).Take(pageSize);

                foreach (var item in query)
                {
                    list.Add(new Alaplap
                    {
                        ID = item.id,
                        FoglalatID = id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        IsPs2 = item.van_ps2_port,
                        Kep = item.kepek.kep,
                        Leiras = item.leiras,
                        Megnevezes = item.megnevezes,
                        MemoriaDarab = item.memoria_foglalat_darab,
                        MemoriaFoglalat = item.memoria_foglalat_tipus.megnevezes,
                        MemoriaFoglalatID = item.memoria_foglalat_tipus_id,
                        NettoAr = item.netto_ar,
                        VGADarab = item.vga_csatolo_darab
                    });
                }

                maxNumber = query.Count();
            }


            return new PageableList<Alaplap>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }

        public PageableList<Billentyuzet> Billentyuzet_GetByUsbID(int id, int pageNumber, int pageSize)
        {
            List<Billentyuzet> list = new List<Billentyuzet>();
            int maxNumber = 0;

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.billentyuzet.Where(i => i.usb_tipus_id==id).OrderBy(i => i.megnevezes).Skip((pageNumber - 1) * pageSize).Take(pageSize);

                foreach (var item in query)
                {
                    list.Add(new Billentyuzet
                    {
                        ID = item.id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        IsPs2 = item.is_ps2_csatolo,
                        Kep = item.kepek.kep,
                        Megnevezes=item.megnevezes,
                        UsbID=item.usb_tipus.id,
                        NettoAr=item.netto_ar
                    });
                }

                maxNumber = query.Count();
            }
            return new PageableList<Billentyuzet>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }
    }
}
