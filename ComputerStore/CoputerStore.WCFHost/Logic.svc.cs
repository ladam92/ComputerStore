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


        public PageableList<Billentyuzet> Billentyuzet_GetByPs(int pageNumber, int pageSize)
        {
            List<Billentyuzet> list = new List<Billentyuzet>();
            int maxNumber = 0;

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.billentyuzet.Where(i => i.is_ps2_csatolo == true).OrderBy(i => i.megnevezes).Skip((pageNumber - 1) * pageSize).Take(pageSize);

                foreach (var item in query)
                {
                    list.Add(new Billentyuzet
                    {
                        ID = item.id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        IsPs2 = item.is_ps2_csatolo,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        UsbID = item.usb_tipus.id,
                        NettoAr = item.netto_ar
                    });
                }

                maxNumber = query.Count();
            }
            return new PageableList<Billentyuzet>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }

        public PageableList<Eger> Eger_GetByUsbID(int id, int pageNumber, int pageSize)
        {
            List<Eger> list = new List<Eger>();
            int maxNumber = 0;

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.eger.Where(i => i.usb_tipus_id == id).OrderBy(i => i.megnevezes).Skip((pageNumber - 1) * pageSize).Take(pageSize);

                foreach (var item in query)
                {
                    list.Add(new Eger
                    {
                        ID = item.id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        IsPs2 = item.is_ps2_csatolo,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        UsbID = item.usb_tipus.id,
                        NettoAr = item.netto_ar
                    });
                }

                maxNumber = query.Count();
            }
            return new PageableList<Eger>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }

        public PageableList<Eger> Eger_GetByPs(int pageNumber, int pageSize)
        {
            List<Eger> list = new List<Eger>();
            int maxNumber = 0;

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.eger.Where(i => i.is_ps2_csatolo == true).OrderBy(i => i.megnevezes).Skip((pageNumber - 1) * pageSize).Take(pageSize);

                foreach (var item in query)
                {
                    list.Add(new Eger
                    {
                        ID = item.id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        IsPs2 = item.is_ps2_csatolo,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        UsbID = item.usb_tipus.id,
                        NettoAr = item.netto_ar
                    });
                }

                maxNumber = query.Count();
            }
            return new PageableList<Eger>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }

        public PageableList<Hattertar> Hattertar_GetByHattertarTipus(int id, int pageNumber, int pageSize)
        {
            List<Hattertar> list = new List<Hattertar>();
            int maxNumber = 0;

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.hattertar.Where(i => i.hattertar_tipus_id == id).OrderBy(i => i.megnevezes).Skip((pageNumber - 1) * pageSize).Take(pageSize);

                foreach (var item in query)
                {
                    list.Add(new Hattertar
                    {
                        ID = item.id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        CsatoloID=item.hattertar_csatolo_tipus_id,
                        TipusID=item.hattertar_tipus_id,
                        Meret=item.meret_gb,
                        NettoAr = item.netto_ar
                    });
                }

                maxNumber = query.Count();
            }
            return new PageableList<Hattertar>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }

        public PageableList<Hattertar> Hattertar_GetByHattertarCsatolo(int id, int pageNumber, int pageSize)
        {
            List<Hattertar> list = new List<Hattertar>();
            int maxNumber = 0;

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.hattertar.Where(i => i.hattertar_csatolo_tipus_id == id).OrderBy(i => i.megnevezes).Skip((pageNumber - 1) * pageSize).Take(pageSize);

                foreach (var item in query)
                {
                    list.Add(new Hattertar
                    {
                        ID = item.id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        CsatoloID = item.hattertar_csatolo_tipus_id,
                        TipusID = item.hattertar_tipus_id,
                        Meret = item.meret_gb,
                        NettoAr = item.netto_ar
                    });
                }

                maxNumber = query.Count();
            }
            return new PageableList<Hattertar>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }


        public PageableList<Memoria> Memoria_GetByFoglalat(int id, int pageNumber, int pageSize)
        {
            List<Memoria> list = new List<Memoria>();
            int maxNumber = 0;

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.memoria.Where(i => i.memoria_foglalat_tipus_id == id).OrderBy(i => i.megnevezes).Skip((pageNumber - 1) * pageSize).Take(pageSize);

                foreach (var item in query)
                {
                    list.Add(new Memoria
                    {
                        ID = item.id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        FoglalatID=item.memoria_foglalat_tipus_id,
                        MemoriaMeret=item.memoria_meret_mb,
                        NettoAr = item.netto_ar
                    });
                }

                maxNumber = query.Count();
            }
            return new PageableList<Memoria>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }

        public PageableList<Monitor> Monitor_GetByMeret(int id, int pageNumber, int pageSize)
        {
            List<Monitor> list = new List<Monitor>();
            int maxNumber = 0;

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.monitor.Where(i => i.monitor_meret_id == id).OrderBy(i => i.megnevezes).Skip((pageNumber - 1) * pageSize).Take(pageSize);

                foreach (var item in query)
                {
                    list.Add(new Monitor
                    {
                        ID = item.id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        CsatoloID = item.monitor_csatolo_id,
                        FelbontasID = item.monitor_felbontas_id,
                        MeretID=item.monitor_meret_id,
                        NettoAr = item.netto_ar
                    });
                }

                maxNumber = query.Count();
            }
            return new PageableList<Monitor>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }

        public PageableList<Monitor> Monitor_GetByFelbontas(int id, int pageNumber, int pageSize)
        {
            List<Monitor> list = new List<Monitor>();
            int maxNumber = 0;

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.monitor.Where(i => i.monitor_felbontas_id == id).OrderBy(i => i.megnevezes).Skip((pageNumber - 1) * pageSize).Take(pageSize);

                foreach (var item in query)
                {
                    list.Add(new Monitor
                    {
                        ID = item.id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        CsatoloID = item.monitor_csatolo_id,
                        FelbontasID = item.monitor_felbontas_id,
                        MeretID = item.monitor_meret_id,
                        NettoAr = item.netto_ar
                    });
                }

                maxNumber = query.Count();
            }
            return new PageableList<Monitor>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }

        public PageableList<Processzor> Processzor_GetByFoglalat(int id, int pageNumber, int pageSize)
        {
            List<Processzor> list = new List<Processzor>();
            int maxNumber = 0;

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.cpu.Where(i => i.proc_foglalat_tipus_id == id).OrderBy(i => i.megnevezes).Skip((pageNumber - 1) * pageSize).Take(pageSize);

                foreach (var item in query)
                {
                    list.Add(new Processzor
                    {
                        ID = item.id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        Frekvencia=item.frekvencia,
                        FrekvenciaMertekID=item.frekvencia_mertekegyseg_id,
                        Magok=item.magok_darab,
                        ProcFoglalatID=item.proc_foglalat_tipus.id,
                        NettoAr = item.netto_ar
                    });
                }

                maxNumber = query.Count();
            }
            return new PageableList<Processzor>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }

        public PageableList<Szamitogephaz> Szamitogephaz_Get(int pageNumber, int pageSize)
        {
            List<Szamitogephaz> list = new List<Szamitogephaz>();
            int maxNumber = 0;

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.szamitogep_haz.OrderBy(i => i.megnevezes).Skip((pageNumber - 1) * pageSize).Take(pageSize);

                foreach (var item in query)
                {
                    list.Add(new Szamitogephaz
                    {
                        ID = item.id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        NettoAr = item.netto_ar
                    });
                }

                maxNumber = query.Count();
            }
            return new PageableList<Szamitogephaz>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }

        public PageableList<Tapegyseg> Tapegyseg_Get(int pageNumber, int pageSize)
        {
            List<Tapegyseg> list = new List<Tapegyseg>();
            int maxNumber = 0;

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.tapegyseg.OrderBy(i => i.megnevezes).Skip((pageNumber - 1) * pageSize).Take(pageSize);

                foreach (var item in query)
                {
                    list.Add(new Tapegyseg
                    {
                        ID = item.id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        NettoAr = item.netto_ar,
                        Teljesitmeny=item.teljesitmeny
                    });
                }

                maxNumber = query.Count();
            }
            return new PageableList<Tapegyseg>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }

        public PageableList<Videokartya> Videokartya_Get(int pageNumber, int pageSize)
        {
            List<Videokartya> list = new List<Videokartya>();
            int maxNumber = 0;

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.videokartya.OrderBy(i => i.megnevezes).Skip((pageNumber - 1) * pageSize).Take(pageSize);

                foreach (var item in query)
                {
                    list.Add(new Videokartya
                    {
                        ID = item.id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        NettoAr = item.netto_ar,
                        MemoriaMeret=item.memoria_meret_gb,
                        MemoriaTipusID=item.memoria_tipus_id
                    });
                }

                maxNumber = query.Count();
            }
            return new PageableList<Videokartya>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }
    }
}
