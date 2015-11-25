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
                        VGADarab = item.vga_csatolo_darab,
                        Db=(Int32)item.db
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
                        VGADarab = item.vga_csatolo_darab,
                        Db=(Int32)item.db
                       
                      
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
                        NettoAr=item.netto_ar,
                        Db = (Int32)item.db
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
                        NettoAr = item.netto_ar,
                        Db = (Int32)item.db
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
                        NettoAr = item.netto_ar,
                        Db = (Int32)item.db
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
                        NettoAr = item.netto_ar,
                        Db = (Int32)item.db
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
                        NettoAr = item.netto_ar,
                        Db = (Int32)item.db
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
                        NettoAr = item.netto_ar,
                        Db = (Int32)item.db
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
                        NettoAr = item.netto_ar,
                        Db = (Int32)item.db
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
                        NettoAr = item.netto_ar,
                        Db = (Int32)item.db
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
                        NettoAr = item.netto_ar,
                        Db = (Int32)item.db
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
                        NettoAr = item.netto_ar,
                        Db = (Int32)item.db
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
                        NettoAr = item.netto_ar,
                        Db = (Int32)item.db
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
                        Teljesitmeny=item.teljesitmeny,
                        Db = (Int32)item.db
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
                        MemoriaTipusID=item.memoria_tipus_id,
                        Db = (Int32)item.db
                    });
                }

                maxNumber = query.Count();
            }
            return new PageableList<Videokartya>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }

        public Alaplap Alaplap_GetByID(int id)
        {
            Alaplap alaplap;
            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.alaplap.Where(i=>i.id==id).Single();
                alaplap = new Alaplap
                {
                    ID = query.id,
                    FoglalatID = query.proc_foglalat_tipus_id,
                    Gyarto = query.alkatresz_gyarto.megnevezes,
                    IsPs2 = query.van_ps2_port,
                    Kep = query.kepek.kep,
                    Leiras = query.leiras,
                    Megnevezes = query.megnevezes,
                    MemoriaDarab = query.memoria_foglalat_darab,
                    MemoriaFoglalat = query.memoria_foglalat_tipus.megnevezes,
                    MemoriaFoglalatID = query.memoria_foglalat_tipus_id,
                    NettoAr = query.netto_ar,
                    VGADarab = query.vga_csatolo_darab,
                    Db=(Int32)query.db
                };
            }
            return alaplap;
        }


        public List<ProcesszorFoglalatTipus> ProcFoglalat_GetKategoriakByName(string name)
        {
            List<ProcesszorFoglalatTipus> ret = new List<ProcesszorFoglalatTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.proc_foglalat_tipus.Where(i => i.megnevezes.StartsWith(name)))
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

        public List<MemoriaTipus> MemoriaFoglalat_GetKaegoriakByName(string name)
        {
            List<MemoriaTipus> ret = new List<MemoriaTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.memoria_foglalat_tipus.Where(i => i.megnevezes.StartsWith(name)))
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

        public List<HattertarTipus> HattertatTipus_GetKaegoriakByName(string name)
        {
            List<HattertarTipus> ret = new List<HattertarTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.hattertar_tipus.Where(i => i.megnevezes.StartsWith(name)))
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

        public List<HattertarCsatoloTipus> HattertatCsatoloTipus_GetKaegoriakByName(string name)
        {
            List<HattertarCsatoloTipus> ret = new List<HattertarCsatoloTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.hattertarolo_csatolo_tipus.Where(i => i.megnevezes.StartsWith(name)))
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

        public List<MonitorFelbontas> MonitorFelbontasTipus_GetKaegoriakByName(string felbontas)
        {
            List<MonitorFelbontas> ret = new List<MonitorFelbontas>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.monitor_felbontas.Where(i => i.felbontás.StartsWith(felbontas)))
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

        public List<MonitorMeret> MonitorMeretTipus_GetKaegoriakByName(string felbontas)
        {
            List<MonitorMeret> ret = new List<MonitorMeret>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.monitor_meret.Where(i => i.meret.StartsWith(felbontas)))
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

        public List<UsbTipus> UsbTipus_GetKaegoriakByName(string name)
        {
            List<UsbTipus> ret = new List<UsbTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.usb_tipus.Where(i => i.megnevezes.StartsWith(name)))
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

        public List<PciExpressTipus> PCIExpress_GetByName(string name)
        {
            List<PciExpressTipus> ret = new List<PciExpressTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.pci_express_tipus.Where(i => i.megnevezes.StartsWith(name)))
                {
                    ret.Add(new PciExpressTipus
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return ret;
        }

        public List<ProcesszorFoglalatTipus> ProcesszorFoglalat_GetByName(string name)
        {
            List<ProcesszorFoglalatTipus> ret = new List<ProcesszorFoglalatTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.proc_foglalat_tipus.Where(i => i.megnevezes.StartsWith(name)))
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

        public List<VgaCsatoloFeluletTipus> VgaCsatolo_GetByName(string name)
        {
            List<VgaCsatoloFeluletTipus> ret = new List<VgaCsatoloFeluletTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.vga_csatolo_felulet_tipus.Where(i => i.megnevezes.StartsWith(name)))
                {
                    ret.Add(new VgaCsatoloFeluletTipus
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return ret;
        }

        public List<AlkatreszGyarto> Gyarto_GetByName(string name)
        {
            List<AlkatreszGyarto> ret = new List<AlkatreszGyarto>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.alkatresz_gyarto.Where(i => i.megnevezes.StartsWith(name)))
                {
                    ret.Add(new AlkatreszGyarto
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return ret;
        }

        public ProcesszorFoglalatTipus ProcFoglalat_GetKategoriaByID(int id)
        {
            ProcesszorFoglalatTipus ret = null;

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.proc_foglalat_tipus.Single(i => i.id == id);

                ret = new ProcesszorFoglalatTipus
                {
                    Megnevezes = entity.megnevezes,
                    ID = entity.id
                };
            }

            return ret;
        }

        public MemoriaTipus MemoriaFoglalat_GetKategoriaByID(int id)
        {
            MemoriaTipus ret = null;

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.memoria_foglalat_tipus.Single(i => i.id == id);

                ret = new MemoriaTipus
                {
                    Megnevezes = entity.megnevezes,
                    ID = entity.id
                };
            }

            return ret;
        }

        public UsbTipus UsbTipus_GetKategoriaByID(int id)
        {
            UsbTipus ret = null;

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.usb_tipus.Single(i => i.id == id);

                ret = new UsbTipus
                {
                    Megnevezes = entity.megnevezes,
                    ID = entity.id
                };
            }

            return ret;
        }

        public HattertarTipus HattertatTipus_GetKategoriaByID(int id)
        {
            HattertarTipus ret = null;

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.hattertar_tipus.Single(i => i.id == id);

                ret = new HattertarTipus
                {
                    Megnevezes = entity.megnevezes,
                    ID = entity.id
                };
            }

            return ret;
        }

        public HattertarCsatoloTipus HattertatCsatoloTipus_GetKategoriaByID(int id)
        {
            HattertarCsatoloTipus ret = null;

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.hattertarolo_csatolo_tipus.Single(i => i.id == id);

                ret = new HattertarCsatoloTipus
                {
                    Megnevezes = entity.megnevezes,
                    ID = entity.id
                };
            }

            return ret;
        }

        public MonitorFelbontas MonitorFelbontasTipus_GetKategoriaByID(int id)
        {
            MonitorFelbontas ret = null;

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.monitor_felbontas.Single(i => i.id == id);

                ret = new MonitorFelbontas
                {
                    Megnevezes = entity.felbontás,
                    ID = entity.id
                };
            }

            return ret;
        }

        public MonitorMeret MonitorMeretTipus_GetKategoriaByID(int id)
        {
            MonitorMeret ret = null;

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.monitor_meret.Single(i => i.id == id);

                ret = new MonitorMeret
                {
                    Megnevezes = entity.meret,
                    ID = entity.id
                };
            }

            return ret;
        }

        public PciExpressTipus PCIExpress_GetByID(int id)
        {
            PciExpressTipus ret = null;

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.pci_express_tipus.Single(i => i.id == id);

                ret = new PciExpressTipus
                {
                    Megnevezes = entity.megnevezes,
                    ID = entity.id
                };
            }

            return ret;
        }

        public ProcesszorFoglalatTipus ProcesszorFoglalat_GetByID(int id)
        {
            ProcesszorFoglalatTipus ret = null;

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.proc_foglalat_tipus.Single(i => i.id == id);

                ret = new ProcesszorFoglalatTipus
                {
                    Megnevezes = entity.megnevezes,
                    ID = entity.id
                };
            }

            return ret;
        }

        public VgaCsatoloFeluletTipus VgaCsatolo_GetByID(int id)
        {
            VgaCsatoloFeluletTipus ret = null;

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.vga_csatolo_felulet_tipus.Single(i => i.id == id);

                ret = new VgaCsatoloFeluletTipus
                {
                    Megnevezes = entity.megnevezes,
                    ID = entity.id
                };
            }

            return ret;
        }

        public AlkatreszGyarto Gyarto_GetByID(int id)
        {
            AlkatreszGyarto ret = null;

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.alkatresz_gyarto.Single(i => i.id == id);

                ret = new AlkatreszGyarto
                {
                    Megnevezes = entity.megnevezes,
                    ID = entity.id
                };
            }

            return ret;
        }

        public void ProcFoglalat_Update(ProcesszorFoglalatTipus type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.proc_foglalat_tipus.Single(i => i.id == type.ID);

                entity.megnevezes = type.Megnevezes;

                ctx.SaveChanges();
            }
        }

        public void MemoriaFoglalat_Update(MemoriaTipus type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.memoria_foglalat_tipus.Single(i => i.id == type.ID);

                entity.megnevezes = type.Megnevezes;

                ctx.SaveChanges();
            }
        }

        public void UsbTipus_Update(UsbTipus type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.usb_tipus.Single(i => i.id == type.ID);

                entity.megnevezes = type.Megnevezes;

                ctx.SaveChanges();
            }
        }

        public void HattertatTipus_Update(HattertarTipus type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.hattertar_tipus.Single(i => i.id == type.ID);

                entity.megnevezes = type.Megnevezes;

                ctx.SaveChanges();
            }
        }

        public void HattertatCsatoloTipus_Update(HattertarCsatoloTipus type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.hattertarolo_csatolo_tipus.Single(i => i.id == type.ID);

                entity.megnevezes = type.Megnevezes;

                ctx.SaveChanges();
            }
        }

        public void MonitorFelbontasTipus_Update(MonitorFelbontas type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.monitor_felbontas.Single(i => i.id == type.ID);

                entity.felbontás = type.Megnevezes;

                ctx.SaveChanges();
            }
        }

        public void MonitorMeretTipus_Update(MonitorMeret meret)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.monitor_meret.Single(i => i.id == meret.ID);

                entity.meret = meret.Megnevezes;

                ctx.SaveChanges();
            }
        }

        public void PCIExpress_Update(PciExpressTipus type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.pci_express_tipus.Single(i => i.id == type.ID);

                entity.megnevezes = type.Megnevezes;

                ctx.SaveChanges();
            }
        }

        public void VgaCsatolo_Update(VgaCsatoloFeluletTipus type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.vga_csatolo_felulet_tipus.Single(i => i.id == type.ID);

                entity.megnevezes = type.Megnevezes;

                ctx.SaveChanges();
            }
        }

        public void Gyarto_Update(AlkatreszGyarto type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.alkatresz_gyarto.Single(i => i.id == type.ID);

                entity.megnevezes = type.Megnevezes;

                ctx.SaveChanges();
            }
        }

        public List<MonitorCsatoloTipus> MonitorCsatolo_GetByName(string name)
        {
            List<MonitorCsatoloTipus> ret = new List<MonitorCsatoloTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.monitor_csatolo.Where(i => i.megnevezes.StartsWith(name)))
                {
                    ret.Add(new MonitorCsatoloTipus
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return ret;
        }

        public MonitorCsatoloTipus MonitorCsatolo_GetByID(int id)
        {
            MonitorCsatoloTipus ret = null;

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.monitor_csatolo.Single(i => i.id == id);

                ret = new MonitorCsatoloTipus
                {
                    Megnevezes = entity.megnevezes,
                    ID = entity.id
                };
            }

            return ret;
        }

        public void MonitorCsatolo_Update(MonitorCsatoloTipus type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.monitor_csatolo.Single(i => i.id == type.ID);

                entity.megnevezes = type.Megnevezes;

                ctx.SaveChanges();
            }
        }

        public void ProcFoglalat_Add(ProcesszorFoglalatTipus type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                proc_foglalat_tipus entity = new proc_foglalat_tipus()
                {
                    megnevezes = type.Megnevezes
                };

                ctx.proc_foglalat_tipus.Add(entity);

                ctx.SaveChanges();
            }
        }

        public void MemoriaFoglalat_Add(MemoriaTipus type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                memoria_foglalat_tipus entity = new memoria_foglalat_tipus()
                {
                    megnevezes = type.Megnevezes
                };

                ctx.memoria_foglalat_tipus.Add(entity);

                ctx.SaveChanges();
            }
        }

        public void UsbTipus_Add(UsbTipus type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                usb_tipus entity = new usb_tipus()
                {
                    megnevezes = type.Megnevezes
                };

                ctx.usb_tipus.Add(entity);

                ctx.SaveChanges();
            }
        }

        public void HattertatTipus_Add(HattertarTipus type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                hattertar_tipus entity = new hattertar_tipus()
                {
                    megnevezes = type.Megnevezes
                };

                ctx.hattertar_tipus.Add(entity);

                ctx.SaveChanges();
            }
        }

        public void HattertatCsatoloTipus_Add(HattertarCsatoloTipus type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                hattertarolo_csatolo_tipus entity = new hattertarolo_csatolo_tipus()
                {
                    megnevezes = type.Megnevezes
                };

                ctx.hattertarolo_csatolo_tipus.Add(entity);

                ctx.SaveChanges();
            }
        }

        public void MonitorFelbontasTipus_Add(MonitorFelbontas type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                monitor_felbontas entity = new monitor_felbontas()
                {
                    felbontás = type.Megnevezes
                };

                ctx.monitor_felbontas.Add(entity);

                ctx.SaveChanges();
            }
        }

        public void MonitorMeretTipus_Add(MonitorMeret meret)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                monitor_meret entity = new monitor_meret()
                {
                    meret = meret.Megnevezes
                };

                ctx.monitor_meret.Add(entity);

                ctx.SaveChanges();
            }
        }

        public void PCIExpress_Add(PciExpressTipus type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                pci_express_tipus entity = new pci_express_tipus()
                {
                    megnevezes = type.Megnevezes
                };

                ctx.pci_express_tipus.Add(entity);

                ctx.SaveChanges();
            }
        }

        public void VgaCsatolo_Add(VgaCsatoloFeluletTipus type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                vga_csatolo_felulet_tipus entity = new vga_csatolo_felulet_tipus()
                {
                    megnevezes = type.Megnevezes
                };

                ctx.vga_csatolo_felulet_tipus.Add(entity);

                ctx.SaveChanges();
            }
        }

        public void Gyarto_Add(AlkatreszGyarto type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                alkatresz_gyarto entity = new alkatresz_gyarto()
                {
                    megnevezes = type.Megnevezes
                };

                ctx.alkatresz_gyarto.Add(entity);

                ctx.SaveChanges();
            }
        }

        public void MonitorCsatolo_Add(MonitorCsatoloTipus type)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                monitor_csatolo entity = new monitor_csatolo()
                {
                    megnevezes = type.Megnevezes
                };

                ctx.monitor_csatolo.Add(entity);

                ctx.SaveChanges();
            }
        }

        public Billentyuzet Billentyuzet_GetByID(int id)
        {
            Billentyuzet billentyuzet;
            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.billentyuzet.Where(i => i.id == id).Single();
                billentyuzet = new Billentyuzet
                {
                    ID = query.id,
                    Gyarto = query.alkatresz_gyarto.megnevezes,
                    Kep = query.kepek.kep,
                    Megnevezes = query.megnevezes,
                    NettoAr = query.netto_ar,
                    Db=(Int32)query.db,
                    IsPs2=query.is_ps2_csatolo,
                    UsbID=query.usb_tipus.id
                    
                };
            }
            return billentyuzet;
        }

        public Eger Eger_GetByID(int id)
        {
            Eger eger;
            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.eger.Where(i => i.id == id).Single();
                eger = new Eger
                {
                    ID = query.id,
                    Gyarto = query.alkatresz_gyarto.megnevezes,
                    Kep = query.kepek.kep,
                    Megnevezes = query.megnevezes,
                    NettoAr = query.netto_ar,
                    Db = (Int32)query.db,
                    IsPs2 = query.is_ps2_csatolo,
                    UsbID = query.usb_tipus.id

                };
            }
            return eger;
        }

        public Hattertar Hattertar_GetByID(int id)
        {
            Hattertar hattertar;
            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.hattertar.Where(i => i.id == id).Single();
                hattertar = new Hattertar
                {
                    ID = query.id,
                    Gyarto = query.alkatresz_gyarto.megnevezes,
                    Kep = query.kepek.kep,
                    Megnevezes = query.megnevezes,
                    NettoAr = query.netto_ar,
                    Db = (Int32)query.db,
                    CsatoloID=query.hattertar_csatolo_tipus_id,
                    Meret=query.meret_gb,
                    TipusID=query.hattertar_tipus_id

                };
            }
            return hattertar;
        }

        public Memoria Memoria_GetByID(int id)
        {
            Memoria memoria;
            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.memoria.Where(i => i.id == id).Single();
                memoria = new Memoria
                {
                    ID = query.id,
                    Gyarto = query.alkatresz_gyarto.megnevezes,
                    Kep = query.kepek.kep,
                    Megnevezes = query.megnevezes,
                    NettoAr = query.netto_ar,
                    Db = (Int32)query.db,
                    FoglalatID=query.memoria_foglalat_tipus_id,
                    MemoriaMeret=query.memoria_meret_mb

                };
            }
            return memoria;
        }

        public Monitor Monitor_GetByID(int id)
        {
            Monitor monitor;
            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.monitor.Where(i => i.id == id).Single();
                monitor = new Monitor
                {
                    ID = query.id,
                    Gyarto = query.alkatresz_gyarto.megnevezes,
                    Kep = query.kepek.kep,
                    Megnevezes = query.megnevezes,
                    NettoAr = query.netto_ar,
                    Db = (Int32)query.db,
                    CsatoloID=query.monitor_csatolo_id,
                    FelbontasID=query.monitor_felbontas_id,
                    MeretID=query.monitor_meret_id

                };
            }
            return monitor;
        }

        public Processzor Processzor_GetByID(int id)
        {
            Processzor processzor;
            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.cpu.Where(i => i.id == id).Single();
                processzor = new Processzor
                {
                    ID = query.id,
                    Gyarto = query.alkatresz_gyarto.megnevezes,
                    Kep = query.kepek.kep,
                    Megnevezes = query.megnevezes,
                    NettoAr = query.netto_ar,
                    Db = (Int32)query.db,
                    Frekvencia=query.frekvencia,
                    FrekvenciaMertekID=query.frekvencia_mertekegyseg_id,
                    Magok=query.magok_darab,
                    ProcFoglalatID=query.proc_foglalat_tipus.id

                };
            }
            return processzor;
        }

        public Szamitogephaz Szamitogephaz_GetByID(int id)
        {
            Szamitogephaz szamitogephaz;
            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.szamitogep_haz.Where(i => i.id == id).Single();
                szamitogephaz = new Szamitogephaz
                {
                    ID = query.id,
                    Gyarto = query.alkatresz_gyarto.megnevezes,
                    Kep = query.kepek.kep,
                    Megnevezes = query.megnevezes,
                    NettoAr = query.netto_ar,
                    Db = (Int32)query.db

                };
            }
            return szamitogephaz;
        }

        public Tapegyseg Tapegyseg_GetByID(int id)
        {
            Tapegyseg tapegyseg;
            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.tapegyseg.Where(i => i.id == id).Single();
                tapegyseg = new Tapegyseg
                {
                    ID = query.id,
                    Gyarto = query.alkatresz_gyarto.megnevezes,
                    Kep = query.kepek.kep,
                    Megnevezes = query.megnevezes,
                    NettoAr = query.netto_ar,
                    Db = (Int32)query.db,

                };
            }
            return tapegyseg;
        }

        public Videokartya Videokartya_GetByID(int id)
        {
            Videokartya videokartya;
            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.videokartya.Where(i => i.id == id).Single();
                videokartya = new Videokartya
                {
                    ID = query.id,
                    Gyarto = query.alkatresz_gyarto.megnevezes,
                    Kep = query.kepek.kep,
                    Megnevezes = query.megnevezes,
                    NettoAr = query.netto_ar,
                    Db = (Int32)query.db,
                    MemoriaMeret=query.memoria_meret_gb,
                    MemoriaTipusID=query.memoria_tipus_id

                };
            }
            return videokartya;

        }
    }
}
