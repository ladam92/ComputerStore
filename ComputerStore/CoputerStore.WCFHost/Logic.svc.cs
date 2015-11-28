using ComputerStore.DAL;
using ComputerStore.DTO.Enums;
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

        public void InsertKep(Byte[] kep)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                kepek uj = new kepek { kep = kep };
                ctx.kepek.Add(uj);
                ctx.SaveChanges();
            }

        
        }

        public void InsertingHattertarDB(int gyarto_id, int csatolo_id, int tipus_id, string megnevezes, int ar, int db, int meret, Byte[] kep)
        {
            using (var ctx = new ComputerStoreEntities())
            {

                kepek k = new kepek { kep = kep };
                ComputerStore.DAL.hattertar uj = new ComputerStore.DAL.hattertar { db = db, alkatresz_gyarto_id = gyarto_id, megnevezes = megnevezes, netto_ar = ar, kepek = k, hattertar_csatolo_tipus_id=csatolo_id, hattertar_tipus_id=tipus_id, meret_gb=meret };

                ctx.hattertar.Add(uj);

                ctx.SaveChanges();
            }
        }

        public void InsertingBillentyuzetDB( int gyarto_id, int usb_id, bool ps2, string megnevezes, int ar, int db, Byte[]kep)
        {
            using (var ctx = new ComputerStoreEntities())
            {

                kepek k = new kepek { kep = kep };
                ComputerStore.DAL.billentyuzet uj = new ComputerStore.DAL.billentyuzet { db = db, alkatresz_gyarto_id = gyarto_id, megnevezes = megnevezes, netto_ar = (Decimal)ar, kepek = k , is_ps2_csatolo=ps2, usb_tipus_id=usb_id};

                ctx.billentyuzet.Add(uj);

                ctx.SaveChanges();
            }

        }

        public void InsertingEgerDB(int gyarto_id, int usb_id, bool ps2, string megnevezes, int ar, int db, Byte[] kep)
        {
            using (var ctx = new ComputerStoreEntities())
            {

                kepek k = new kepek { kep = kep };
                ComputerStore.DAL.eger uj = new ComputerStore.DAL.eger { db = db, alkatresz_gyarto_id = gyarto_id, megnevezes = megnevezes, netto_ar = (Decimal)ar, kepek = k, is_ps2_csatolo = ps2, usb_tipus_id = usb_id };

                ctx.eger.Add(uj);

                ctx.SaveChanges();
            }
        }

        public void InsertingMemoriaDB(int gyarto_id, int foglalat_id, string megnevezes, int ar, int db, int meret, Byte[] kep)
        {
            using (var ctx = new ComputerStoreEntities())
            {

                kepek k = new kepek { kep = kep };
                ComputerStore.DAL.memoria uj = new ComputerStore.DAL.memoria { db = db, alkatresz_gyarto_id = gyarto_id, megnevezes = megnevezes, netto_ar = (Decimal)ar, kepek = k, memoria_foglalat_tipus_id=foglalat_id, memoria_meret_mb=meret };

                ctx.memoria.Add(uj);

                ctx.SaveChanges();
            }
        }

        public void InsertingMonitorDB(int gyarto_id, int csatolo_id, int felbontas_id, int meret_id, string megnev, int ar, int db, Byte[] kep)
        {
            using (var ctx = new ComputerStoreEntities())
            {

                kepek k = new kepek { kep = kep };
                ComputerStore.DAL.monitor uj = new ComputerStore.DAL.monitor { db = db, alkatresz_gyarto_id = gyarto_id, megnevezes = megnev, netto_ar = (Decimal)ar, kepek = k, monitor_csatolo_id=csatolo_id, monitor_felbontas_id=felbontas_id, monitor_meret_id=meret_id};

                ctx.monitor.Add(uj);

                ctx.SaveChanges();
            }
        }

        public void InsertingProcesszorDB(int gyarto_id, int foglalat_id, string meg, int ar, int db, int magok, int frekvencia, Byte[] kep)
        {
            using (var ctx = new ComputerStoreEntities())
            {

                kepek k = new kepek { kep = kep };
                ComputerStore.DAL.cpu uj = new ComputerStore.DAL.cpu { db = db, alkatresz_gyarto_id = gyarto_id, megnevezes = meg, netto_ar = (Decimal)ar, kepek = k, proc_foglalat_tipus_id=foglalat_id, magok_darab=magok, frekvencia=frekvencia, frekvencia_mertekegyseg_id=1 };

                ctx.cpu.Add(uj);

                ctx.SaveChanges();
            }
        }

        public void InsertingSzamitogephazDB(int gyarto_id, string megnev, int ar, int db, Byte[] kep)
        {
            using (var ctx = new ComputerStoreEntities())
            {

                kepek k = new kepek { kep = kep };
                ComputerStore.DAL.szamitogep_haz uj = new ComputerStore.DAL.szamitogep_haz { db = db, alkatresz_gyarto_id = gyarto_id, megnevezes = megnev, netto_ar = (Decimal)ar, kepek = k };

                ctx.szamitogep_haz.Add(uj);

                ctx.SaveChanges();
            }
        }

        public void InsertingVideokartyaDB(int csatolo_id, int mondb, int gyarto_id, int memoria_id, string megnev, int ar, int db, int meret, Byte[] kep)
        {
            using (var ctx = new ComputerStoreEntities())
            {

                kepek k = new kepek { kep = kep };
                ComputerStore.DAL.videokartya uj = new ComputerStore.DAL.videokartya { db = db, alkatresz_gyarto_id = gyarto_id, megnevezes = megnev, netto_ar = (Decimal)ar, kepek = k, memoria_meret_gb=meret, memoria_tipus_id=memoria_id};
                ComputerStore.DAL.videokartya_monitor uj2 = new ComputerStore.DAL.videokartya_monitor();
                uj2.videokartya = uj;
                uj2.monitor_csatolo_id = csatolo_id;
                uj2.darab = mondb;

                ctx.videokartya_monitor.Add(uj2);

                ctx.SaveChanges();
            }
        }

        public void InsertingTapegysegDB(int gyarto_id, string megnev, int ar, int db, int telj, Byte[] kep)
        {
            using (var ctx = new ComputerStoreEntities())
            {

                kepek k = new kepek { kep = kep };
                ComputerStore.DAL.tapegyseg uj = new ComputerStore.DAL.tapegyseg { db = db, alkatresz_gyarto_id = gyarto_id, megnevezes = megnev, netto_ar = (Decimal)ar, kepek = k, teljesitmeny=telj };

                ctx.tapegyseg.Add(uj);

                ctx.SaveChanges();
            }
        }

        public void InsertingAlaplapDB(int usb_id, int hattertar_id, int gyarto_id, int foglalat_id, int memoria_id, int vga_id, int pci_id, int mem_db, int vga_db, bool ps2, string megnevezes, int ar, int db, Byte[] kep, int hatdb, int usbdb)
        {
            using (var ctx = new ComputerStoreEntities())
            {
             
                kepek k = new kepek { kep = kep };
                ComputerStore.DAL.alaplap uj = new ComputerStore.DAL.alaplap {db=db, alkatresz_gyarto_id=gyarto_id, megnevezes=megnevezes, memoria_foglalat_tipus_id=memoria_id, netto_ar=(Decimal)ar, pci_express_tipus_id=pci_id, proc_foglalat_tipus_id=foglalat_id, van_ps2_port=ps2, vga_csatolo_felulet_tipus_id=vga_id, memoria_foglalat_darab=mem_db, vga_csatolo_darab=vga_db, kepek = k};
                
                ComputerStore.DAL.alaplap_usb uj2 = new ComputerStore.DAL.alaplap_usb();
                uj2.alaplap = uj;
                uj2.darab = usbdb;
                uj2.usb_tipus_id = usb_id;

                ctx.alaplap_usb.Add(uj2);

                ComputerStore.DAL.alaplap_hattertar uj3 = new ComputerStore.DAL.alaplap_hattertar();
                uj3.alaplap = uj;
                uj3.darab = hatdb;
                uj3.hattertar_csatolo_tipus_id = hattertar_id;

                ctx.alaplap_hattertar.Add(uj3);

                ctx.SaveChanges();
            }
        }

        public void InsertAlaplap( int csatolo_id, int usb_id, int usbdb, int hatdb, int id, int gyarto_id, int foglalat_id, int memoria_id, int vga_id, int pci_id, int mem_db, int vga_db, bool ps2, string megnevezes, int ar, int db )
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var alaplap = ctx.alaplap.Where(i => i.id == id).Single();
                //var gyarto=ctx.alkatresz_gyarto.Where(i=>i.id==gyarto_id).Single();
                alaplap.alkatresz_gyarto_id = gyarto_id;
                alaplap.proc_foglalat_tipus_id = foglalat_id;
                alaplap.memoria_foglalat_tipus_id = memoria_id;
                alaplap.vga_csatolo_felulet_tipus_id = vga_id;
                alaplap.pci_express_tipus_id = pci_id;
                alaplap.memoria_foglalat_darab = mem_db;
                alaplap.vga_csatolo_darab = vga_db;
                alaplap.van_ps2_port = ps2;
                alaplap.megnevezes = megnevezes;
                alaplap.netto_ar = ar;
                alaplap.db = db;

                var alapusb = ctx.alaplap_usb.Where(i => i.alaplap_id == id).Single();
                alapusb.darab = usbdb;
                alapusb.usb_tipus_id = usb_id;

                var alaphat = ctx.alaplap_hattertar.Where(i => i.alaplap_id == id).Single();
                alaphat.darab = hatdb;
                alaphat.hattertar_csatolo_tipus_id = csatolo_id;

                ctx.SaveChanges();
            }
        }

        public AlaplapUSB USBGetByAlaplapID(int id)
        {
            AlaplapUSB uj=new AlaplapUSB();
            using(var ctx=new ComputerStoreEntities()){
               var model=ctx.alaplap_usb.Where(i=>i.alaplap_id==id).Single();
               uj.Alaplap_ID = (Int32)model.alaplap_id;
               uj.Darab = model.darab;
               uj.USB_ID = (Int32)model.usb_tipus_id;
               uj.ID = model.id;
            }
            return uj;
        }

        public AlaplapHatter HattertarGetByAlaplapID(int id)
        {
            AlaplapHatter uj=new AlaplapHatter();
            using (var ctx = new ComputerStoreEntities())
            {
                var model = ctx.alaplap_hattertar.Where(i => i.alaplap_id == id).Single();
                uj.Alaplap_ID = (Int32)model.alaplap_id;
                uj.Darab = model.darab;
                uj.Csatolo_ID = (Int32)model.hattertar_csatolo_tipus_id;
                uj.ID = model.id;
            }
            return uj;
        }

        public VideokartyaMon MonitorcsatoloGetByVideokartyaID(int id)
        {
            VideokartyaMon uj=new VideokartyaMon();
            using (var ctx = new ComputerStoreEntities())
            {
                var model = ctx.videokartya_monitor.Where(i => i.videokartya_id == id).Single();
                uj.ID = model.id;
                uj.Darab = model.darab;
                uj.VideokartyaID = model.videokartya_id;
                uj.CsatoloID = model.monitor_csatolo_id;
            }
            return uj;

        }



        public void InsertBillentyuzet(int id, int gyarto_id, int usb_id, bool ps2, string megnevezes, int ar, int db)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var billentyuzet = ctx.billentyuzet.Where(i => i.id == id).Single();
                //var gyarto=ctx.alkatresz_gyarto.Where(i=>i.id==gyarto_id).Single();
                billentyuzet.alkatresz_gyarto_id = gyarto_id;
                billentyuzet.is_ps2_csatolo = ps2;
                billentyuzet.usb_tipus_id = usb_id;
                billentyuzet.megnevezes = megnevezes;
                billentyuzet.netto_ar = ar;
                billentyuzet.db = db;

                ctx.SaveChanges();
            }
        }

        public void InsertEger(int id, int gyarto_id, int usb_id, bool ps2, string megnevezes, int ar, int db)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var eger = ctx.eger.Where(i => i.id == id).Single();
                //var gyarto=ctx.alkatresz_gyarto.Where(i=>i.id==gyarto_id).Single();
                eger.alkatresz_gyarto_id = gyarto_id;
                eger.is_ps2_csatolo = ps2;
                eger.usb_tipus_id = usb_id;
                eger.megnevezes = megnevezes;
                eger.netto_ar = ar;
                eger.db = db;

                ctx.SaveChanges();
            }
        }

        public void InsertSzamitogephaz(int id, int gyarto_id, string megnev, int ar, int db){
            using (var ctx = new ComputerStoreEntities())
            {
                var haz = ctx.szamitogep_haz.Where(i => i.id == id).Single();
                //var gyarto=ctx.alkatresz_gyarto.Where(i=>i.id==gyarto_id).Single();
                haz.alkatresz_gyarto_id = gyarto_id;
                haz.megnevezes = megnev;
                haz.netto_ar = ar;
                haz.db = db;

                ctx.SaveChanges();
            }
        }

        public void InsertTapegyseg(int id, int gyarto_id, string megnev, int ar, int db, int telj){
            using (var ctx = new ComputerStoreEntities())
            {
                var tap = ctx.tapegyseg.Where(i => i.id == id).Single();
                //var gyarto=ctx.alkatresz_gyarto.Where(i=>i.id==gyarto_id).Single();
                tap.alkatresz_gyarto_id = gyarto_id;
                tap.megnevezes = megnev;
                tap.netto_ar = ar;
                tap.db = db;
                tap.teljesitmeny = telj;

                ctx.SaveChanges();
            }
        }

        public void InsertVideokartya(int csatolo_id, int csatdb, int id, int gyarto_id, int memoria_id, string megnev, int ar, int db, int meret)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var vid = ctx.videokartya.Where(i => i.id == id).Single();
                //var gyarto=ctx.alkatresz_gyarto.Where(i=>i.id==gyarto_id).Single();
                vid.alkatresz_gyarto_id = gyarto_id;
                vid.megnevezes = megnev;
                vid.netto_ar = ar;
                vid.db = db;
                vid.memoria_meret_gb = meret;
                vid.memoria_tipus_id = memoria_id;

                var videomon = ctx.videokartya_monitor.Where(i => i.videokartya_id == id).Single();
                videomon.darab = csatdb;
                videomon.monitor_csatolo_id = csatolo_id;

                ctx.SaveChanges();
            }
        }

        public void InsertMemoria(int id, int gyarto_id, int foglalat_id, string megnevezes, int ar, int db, int meret){
            using (var ctx = new ComputerStoreEntities())
            {
                var mem = ctx.memoria.Where(i => i.id == id).Single();
                //var gyarto=ctx.alkatresz_gyarto.Where(i=>i.id==gyarto_id).Single();
                mem.alkatresz_gyarto_id = gyarto_id;
                mem.megnevezes = megnevezes;
                mem.netto_ar = ar;
                mem.db = db;
                mem.memoria_foglalat_tipus_id = foglalat_id;
                mem.memoria_meret_mb = meret;

                ctx.SaveChanges();
            }
        }

        public void InsertMonitor(int id, int gyarto_id, int csatolo_id, int felbontas_id, int meret_id, string megnev, int ar, int db){
            using (var ctx = new ComputerStoreEntities())
            {
                var mon = ctx.monitor.Where(i => i.id == id).Single();
                //var gyarto=ctx.alkatresz_gyarto.Where(i=>i.id==gyarto_id).Single();
                mon.alkatresz_gyarto_id = gyarto_id;
                mon.megnevezes = megnev;
                mon.netto_ar = ar;
                mon.db = db;
                mon.monitor_csatolo_id = csatolo_id;
                mon.monitor_felbontas_id = felbontas_id;
                mon.monitor_meret_id = meret_id;

                ctx.SaveChanges();
            }

        }

        public void InsertHattertar(int id, int gyarto_id, int csatolo_id, int tipus_id, string megnevezes, int ar, int db, int meret){
            
            using (var ctx = new ComputerStoreEntities())
            {
                var hatter = ctx.hattertar.Where(i => i.id == id).Single();
                hatter.alkatresz_gyarto_id = gyarto_id;
                hatter.megnevezes = megnevezes;
                hatter.netto_ar = ar;
                hatter.db = db;
                hatter.hattertar_csatolo_tipus_id = csatolo_id;
                hatter.hattertar_tipus_id = tipus_id;
                hatter.meret_gb = meret;

                ctx.SaveChanges();
            }

        }

        public void InsertCPU(int id, int gyarto_id, int foglalat_id, string meg, int ar, int db, int magok, int frekvencia)
        {
            using (var ctx = new ComputerStoreEntities())
                {
                    var cpu = ctx.cpu.Where(i => i.id == id).Single();
                
                    cpu.alkatresz_gyarto_id = gyarto_id;
                    cpu.proc_foglalat_tipus_id = foglalat_id;
                    cpu.megnevezes = meg;
                    cpu.netto_ar = ar;
                    cpu.db = db;
                    cpu.magok_darab = magok;
                    cpu.frekvencia = frekvencia;

                    ctx.SaveChanges();
                }
        }

        public void DeleteAlaplap(int id)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var alaplap1 = ctx.alaplap.Where(i => i.id == id).Single();
                var list=ctx.alaplap_usb.Where(i => i.alaplap_id == id);
                foreach (var item in list)
                {
                    ctx.alaplap_usb.Remove(item);
                }
                var list2 = ctx.alaplap_hattertar.Where(i => i.alaplap_id == id);
                foreach (var item in list2)
                {
                    ctx.alaplap_hattertar.Remove(item);
                }
                ctx.alaplap.Remove(alaplap1);
                
                ctx.SaveChanges();
            }
        }


        public void DeleteBillentyuzet(int id)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var billen1 = ctx.billentyuzet.Where(i => i.id == id).Single();              
                ctx.billentyuzet.Remove(billen1);
                ctx.SaveChanges();
            }
        }

        public void DeleteEger(int id)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var eger1 = ctx.eger.Where(i => i.id == id).Single();
                ctx.eger.Remove(eger1);
                ctx.SaveChanges();
            }
        }

        public void DeleteHattertar(int id)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var hattertar1 = ctx.hattertar.Where(i => i.id == id).Single();
                ctx.hattertar.Remove(hattertar1);
                ctx.SaveChanges();
            }
        }

        public void DeleteMemoria(int id)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var memoria1 = ctx.memoria.Where(i => i.id == id).Single();
                ctx.memoria.Remove(memoria1);
                ctx.SaveChanges();
            }
        }

        public void DeleteMonitor(int id)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var monitor1 = ctx.monitor.Where(i => i.id == id).Single();
                ctx.monitor.Remove(monitor1);
                ctx.SaveChanges();
            }
        }

        public void DeleteProcesszor(int id)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var cpu1 = ctx.cpu.Where(i => i.id == id).Single();
                ctx.cpu.Remove(cpu1);
                ctx.SaveChanges();
            }
        }

        public void DeleteSzamitogephaz(int id)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var haz1 = ctx.szamitogep_haz.Where(i => i.id == id).Single();
                ctx.szamitogep_haz.Remove(haz1);
                ctx.SaveChanges();
            }
        }

        public void DeleteTapegyseg(int id)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var tap1 = ctx.tapegyseg.Where(i => i.id == id).Single();
                ctx.tapegyseg.Remove(tap1);
                ctx.SaveChanges();
            }
        }

        public void DeleteVideokartya(int id)
        {
            using (var ctx = new ComputerStoreEntities())
            {
                var vid1 = ctx.videokartya.Where(i => i.id == id).Single();
                var list = ctx.videokartya_monitor.Where(i => i.videokartya_id == id);
                foreach (var item in list)
                {
                    ctx.videokartya_monitor.Remove(item);
                }
                
                ctx.videokartya.Remove(vid1);

                ctx.SaveChanges();
            }
        }

        public List<Fokategoriatipus> GetAlaplap()
        {
            List<Fokategoriatipus> ret = new List<Fokategoriatipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.alaplap)
                {
                    ret.Add(new Fokategoriatipus
                    {
                        ID = item.id,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        Tipus="Alaplap"
                    });
                }
            }

            return ret;
        }

        public List<Fokategoriatipus> GetBillentyuzet()
        {
            List<Fokategoriatipus> ret = new List<Fokategoriatipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.billentyuzet)
                {
                    ret.Add(new Fokategoriatipus
                    {
                        ID = item.id,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        Tipus = "Billentyuzet"
                    });
                }
            }

            return ret;
        }

        public List<Fokategoriatipus> GetEger()
        {
            List<Fokategoriatipus> ret = new List<Fokategoriatipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.eger)
                {
                    ret.Add(new Fokategoriatipus
                    {
                        ID = item.id,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        Tipus = "Eger"
                    });
                }
            }

            return ret;
        }

        public List<Fokategoriatipus> GetHattertar()
        {
            List<Fokategoriatipus> ret = new List<Fokategoriatipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.hattertar)
                {
                    ret.Add(new Fokategoriatipus
                    {
                        ID = item.id,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        Tipus = "Hattertar"
                    });
                }
            }

            return ret;
        }

        public List<Fokategoriatipus> GetMemoria()
        {
            List<Fokategoriatipus> ret = new List<Fokategoriatipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.memoria)
                {
                    ret.Add(new Fokategoriatipus
                    {
                        ID = item.id,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        Tipus = "Memoria"
                    });
                }
            }

            return ret;
        }

        public List<Fokategoriatipus> GetMonitor()
        {
            List<Fokategoriatipus> ret = new List<Fokategoriatipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.monitor)
                {
                    ret.Add(new Fokategoriatipus
                    {
                        ID = item.id,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        Tipus = "Monitor"
                    });
                }
            }

            return ret;
        }

        public List<Fokategoriatipus> GetProcesszor()
        {
            List<Fokategoriatipus> ret = new List<Fokategoriatipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.cpu)
                {
                    ret.Add(new Fokategoriatipus
                    {
                        ID = item.id,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        Tipus = "Processzor"
                    });
                }
            }

            return ret;
        }

        public List<Fokategoriatipus> GetSzamitogephaz()
        {
            List<Fokategoriatipus> ret = new List<Fokategoriatipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.szamitogep_haz)
                {
                    ret.Add(new Fokategoriatipus
                    {
                        ID = item.id,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        Tipus = "Szamitogephaz"
                    });
                }
            }

            return ret;
        }

        public List<Fokategoriatipus> GetTapegyseg()
        {
            List<Fokategoriatipus> ret = new List<Fokategoriatipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.tapegyseg)
                {
                    ret.Add(new Fokategoriatipus
                    {
                        ID = item.id,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        Tipus = "Tapegyseg"
                    });
                }
            }

            return ret;
        }

        public List<Fokategoriatipus> GetVideokartya()
        {
            List<Fokategoriatipus> ret = new List<Fokategoriatipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.videokartya)
                {
                    ret.Add(new Fokategoriatipus
                    {
                        ID = item.id,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        Tipus = "Videokartya"
                    });
                }
            }

            return ret;
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
                        Foglalat = item.proc_foglalat_tipus.megnevezes,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        IsPs2 = item.van_ps2_port,
                        Kep = item.kepek != null ? item.kepek.kep : null,
                        Megnevezes = item.megnevezes,
                        MemoriaDarab = item.memoria_foglalat_darab,
                        MemoriaFoglalat = item.memoria_foglalat_tipus.megnevezes,
                        MemoriaFoglalatID = item.memoria_foglalat_tipus_id,
                        NettoAr = item.netto_ar,
                        VGADarab = item.vga_csatolo_darab,
                        VGA=item.vga_csatolo_felulet_tipus.megnevezes,
                        VGAID=item.vga_csatolo_felulet_tipus_id,
                        Db=(Int32)item.db,
                        PCI=item.pci_express_tipus.megnevezes,
                        PCIID=(Int32)item.pci_express_tipus_id
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
                        Foglalat = item.proc_foglalat_tipus.megnevezes,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        IsPs2 = item.van_ps2_port,
                        Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        MemoriaDarab = item.memoria_foglalat_darab,
                        MemoriaFoglalat = item.memoria_foglalat_tipus.megnevezes,
                        MemoriaFoglalatID = item.memoria_foglalat_tipus_id,
                        NettoAr = item.netto_ar,
                        VGADarab = item.vga_csatolo_darab,
                        VGA = item.vga_csatolo_felulet_tipus.megnevezes,
                        VGAID = item.vga_csatolo_felulet_tipus_id,
                        Db=(Int32)item.db,
                        PCI = item.pci_express_tipus.megnevezes,
                        PCIID = (Int32)item.pci_express_tipus_id
                       
                      
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
                        Usb = item.usb_tipus.megnevezes,
                        UsbID =item.usb_tipus.id,
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
                        Usb = item.usb_tipus.megnevezes,
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
                        Usb = item.usb_tipus.megnevezes,
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
                        Usb = item.usb_tipus.megnevezes,
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
                        Csatolo = item.hattertarolo_csatolo_tipus.megnevezes,
                        Tipus = item.hattertar_tipus.megnevezes,
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
                        Csatolo = item.hattertarolo_csatolo_tipus.megnevezes,
                        Tipus = item.hattertar_tipus.megnevezes,
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
                        Foglalat = item.memoria_foglalat_tipus.megnevezes,
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
                        Csatolo = item.monitor_csatolo.megnevezes,
                        Felbontas = item.monitor_felbontas.felbontás,
                        Meret = item.monitor_meret.meret,
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
                        Csatolo = item.monitor_csatolo.megnevezes,
                        Felbontas = item.monitor_felbontas.felbontás,
                        Meret = item.monitor_meret.meret,
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
                        FrekvenciaMertek = item.cpu_frekvencia_mertekegyseg.mertekegyseg,
                        FrekvenciaMertekID=item.frekvencia_mertekegyseg_id,
                        Magok=item.magok_darab,
                        ProcFoglalat = item.proc_foglalat_tipus.megnevezes,
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
                        MemoriaTipus = item.memoria_foglalat_tipus.megnevezes,
                        MemoriaTipusID=item.memoria_tipus_id,
                        Db = (Int32)item.db
                    });
                }

                maxNumber = query.Count();
            }
            return new PageableList<Videokartya>(list, pageNumber, (int)Math.Ceiling((decimal)maxNumber / pageSize));
        }

        //public Alaplap Alaplap_GetByID(int id)
        //{
        //    Alaplap alaplap;
        //    using (var ctx = new ComputerStoreEntities())
        //    {
        //        var query = ctx.alaplap.Where(i=>i.id==id).Single();
        //        alaplap = new Alaplap
        //        {
        //            ID = query.id,
        //            FoglalatID = query.proc_foglalat_tipus_id,
        //            Gyarto = query.alkatresz_gyarto.megnevezes,
        //            IsPs2 = query.van_ps2_port,
        //            Kep = query.kepek.kep,
        //            Leiras = query.leiras,
        //            Megnevezes = query.megnevezes,
        //            MemoriaDarab = query.memoria_foglalat_darab,
        //            MemoriaFoglalat = query.memoria_foglalat_tipus.megnevezes,
        //            MemoriaFoglalatID = query.memoria_foglalat_tipus_id,
        //            NettoAr = query.netto_ar,
        //            VGADarab = query.vga_csatolo_darab,
        //            Db=(Int32)query.db
        //        };
        //    }
        //    return alaplap;
        //}


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

        public List<UsbTipus> UsbGet()
        {
            List<UsbTipus> list = new List<UsbTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.usb_tipus;
                foreach (var item in entity)
                {
                    list.Add(new UsbTipus
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return list;
        }

        public List<MonitorMeret> MonitorMeretGet()
        {
            List<MonitorMeret> list = new List<MonitorMeret>();

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.monitor_meret;
                foreach (var item in entity)
                {
                    list.Add(new MonitorMeret
                    {
                        ID = item.id,
                        Megnevezes = item.meret
                    });
                }
            }

            return list;
        }

        public List<MonitorFelbontas> MonitorFelbontasGet()
        {
            List<MonitorFelbontas> list = new List<MonitorFelbontas>();

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.monitor_felbontas;
                foreach (var item in entity)
                {
                    list.Add(new MonitorFelbontas
                    {
                        ID = item.id,
                        Megnevezes = item.felbontás
                    });
                }
            }

            return list;
        }

        public List<MonitorCsatoloTipus> MonitorCsatoloTipusGet()
        {
            List<MonitorCsatoloTipus> list = new List<MonitorCsatoloTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.monitor_csatolo;
                foreach (var item in entity)
                {
                    list.Add(new MonitorCsatoloTipus
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return list;
        }

        public List<HattertarTipus> HattertarTipusGet()
        {
            List<HattertarTipus> list = new List<HattertarTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.hattertar_tipus;
                foreach (var item in entity)
                {
                    list.Add(new HattertarTipus
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return list;
        }

        public List<HattertarCsatoloTipus> HattertarCsatoloTipusGet()
        {
            List<HattertarCsatoloTipus> list = new List<HattertarCsatoloTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.hattertarolo_csatolo_tipus;
                foreach (var item in entity)
                {
                    list.Add(new HattertarCsatoloTipus
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return list;
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

        public List<PciExpressTipus> PciGet()
        {
            List<PciExpressTipus> list = new List<PciExpressTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.pci_express_tipus;
                foreach (var item in entity)
                {
                    list.Add(new PciExpressTipus
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return list;
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

        public List<ProcesszorFoglalatTipus> ProcesszorGet()
        {
            List<ProcesszorFoglalatTipus> list = new List<ProcesszorFoglalatTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.proc_foglalat_tipus;
                foreach (var item in entity)
                {
                    list.Add(new ProcesszorFoglalatTipus
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return list;
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

        public List<VgaCsatoloFeluletTipus> VgaGet()
        {
            List<VgaCsatoloFeluletTipus> list = new List<VgaCsatoloFeluletTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.vga_csatolo_felulet_tipus;
                foreach (var item in entity)
                {
                    list.Add(new VgaCsatoloFeluletTipus
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return list;
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

        public List<AlkatreszGyarto> GyartoGet()
        {
            List<AlkatreszGyarto> list = new List<AlkatreszGyarto>();

            using(var ctx=new ComputerStoreEntities()){
                var entity=ctx.alkatresz_gyarto;
                foreach(var item in entity){
                    list.Add(new AlkatreszGyarto{
                        ID=item.id, Megnevezes=item.megnevezes
                    });
                }
            }

            return list;
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

        public Alaplap Alaplap_GetByID(int id)
        {
            Alaplap alaplap;
            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.alaplap.Where(i => i.id == id).Single();
                alaplap = new Alaplap
                {
                    ID = id,
                    FoglalatID = query.proc_foglalat_tipus_id,
                    Gyarto = query.alkatresz_gyarto.megnevezes,
                    IsPs2 = query.van_ps2_port,
                    Kep = query.kepek.kep,
                    Megnevezes = query.megnevezes,
                    MemoriaDarab = query.memoria_foglalat_darab,
                    MemoriaFoglalat = query.memoria_foglalat_tipus.megnevezes,
                    MemoriaFoglalatID = query.memoria_foglalat_tipus_id,
                    NettoAr = query.netto_ar,
                    VGADarab = query.vga_csatolo_darab,
                    VGA = query.vga_csatolo_felulet_tipus.megnevezes,
                    VGAID = query.vga_csatolo_felulet_tipus_id,
                    Db = (Int32)query.db,
                    PCI = query.pci_express_tipus.megnevezes,
                    PCIID = (Int32)query.pci_express_tipus_id
                };
            }
            return alaplap;
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

        public List<MemoriaTipus> MemoriaGet()
        {
            List<MemoriaTipus> list = new List<MemoriaTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                var entity = ctx.memoria_foglalat_tipus;
                foreach (var item in entity)
                {
                    list.Add(new MemoriaTipus
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return list;
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
                    Teljesitmeny=query.teljesitmeny

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

        public List<Alaplap> Alaplap_GetListByFoglalatID(int id)
        {
            List<Alaplap> ret = new List<Alaplap>();

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.alaplap.Where(i => i.proc_foglalat_tipus_id == id);

                foreach (var item in query)
                {
                    ret.Add(new Alaplap
                    {
                        ID = item.id,
                        FoglalatID = id,
                        Foglalat = item.proc_foglalat_tipus.megnevezes,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        IsPs2 = item.van_ps2_port,
                        //Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        MemoriaDarab = item.memoria_foglalat_darab,
                        MemoriaFoglalat = item.memoria_foglalat_tipus.megnevezes,
                        MemoriaFoglalatID = item.memoria_foglalat_tipus_id,
                        NettoAr = item.netto_ar,
                        VGADarab = item.vga_csatolo_darab,
                        VGA = item.vga_csatolo_felulet_tipus.megnevezes,
                        VGAID = item.vga_csatolo_felulet_tipus_id,
                        Db = (Int32)item.db,
                        PCI = item.pci_express_tipus.megnevezes,
                        PCIID = (Int32)item.pci_express_tipus_id
                    });
                }

                return ret;
            }
        }

        public List<Processzor> Processzor_GetListByFoglalat(int id)
        {
            List<Processzor> ret = new List<Processzor>();

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.cpu.Where(i => i.proc_foglalat_tipus_id == id);

                foreach (var item in query)
                {
                    ret.Add(new Processzor
                    {
                        ID = item.id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        //Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        Frekvencia = item.frekvencia,
                        FrekvenciaMertek = item.cpu_frekvencia_mertekegyseg.mertekegyseg,
                        FrekvenciaMertekID = item.frekvencia_mertekegyseg_id,
                        Magok = item.magok_darab,
                        ProcFoglalat = item.proc_foglalat_tipus.megnevezes,
                        ProcFoglalatID = item.proc_foglalat_tipus.id,
                        NettoAr = item.netto_ar,
                        Db = (Int32)item.db
                    });
                }

                return ret;
            }
        }

        public List<Memoria> Memoria_GetListByFoglalat(int id)
        {
            List<Memoria> ret = new List<Memoria>();

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.memoria.Where(i => i.memoria_foglalat_tipus_id == id);

                foreach (var item in query)
                {
                    ret.Add(new Memoria
                    {
                        ID = item.id,
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        //Kep = item.kepek.kep,
                        Megnevezes = item.megnevezes,
                        Foglalat = item.memoria_foglalat_tipus.megnevezes,
                        FoglalatID = item.memoria_foglalat_tipus_id,
                        MemoriaMeret = item.memoria_meret_mb,
                        NettoAr = item.netto_ar,
                        Db = (Int32)item.db
                    });
                }

                return ret;
            }
        }

        public List<Videokartya> Videokartya_GetList()
        {
            List<Videokartya> ret = new List<Videokartya>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.videokartya)
                {
                    ret.Add(new Videokartya {
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        ID = item.id,
                        Megnevezes = item.megnevezes,
                        MemoriaMeret = item.memoria_meret_gb,
                        NettoAr = item.netto_ar
                    });
                }
            }

            return ret;
        }

        public List<Hattertar> Hattertar_GetListByAlaplapAndTipus(int alaplapId, int tipus)
        {
            List<Hattertar> ret = new List<Hattertar>();

            using (var ctx = new ComputerStoreEntities())
            {
                var alaplap = ctx.alaplap.Single(i => i.id == alaplapId);

                foreach (var item in alaplap.alaplap_hattertar)
                {
                    foreach (var hatterTar in item.hattertarolo_csatolo_tipus.hattertar.Where(i => i.hattertar_tipus_id == tipus))
                    {
                        ret.Add(new Hattertar {
                            Csatolo = hatterTar.hattertarolo_csatolo_tipus.megnevezes,
                            Gyarto = hatterTar.alkatresz_gyarto.megnevezes,
                            Megnevezes = hatterTar.megnevezes,
                            NettoAr = hatterTar.netto_ar,
                            Meret = hatterTar.meret_gb,
                            ID = hatterTar.id
                        });
                    }
                }
            }

            return ret;
        }

        public List<UsbTipus> Alaplap_GetUsbTipusok(int alaplapID)
        {
            List<UsbTipus> ret = new List<UsbTipus>();

            using (var ctx = new ComputerStoreEntities())
            {
                var alaplap = ctx.alaplap.Single(i => i.id == alaplapID);

                foreach (var item in alaplap.alaplap_usb)
                {
                    ret.Add(new UsbTipus {
                        Megnevezes = item.usb_tipus.megnevezes,
                        ID = item.usb_tipus_id.Value
                    });

                }
            }

            return ret;
        }

        public List<Billentyuzet> Billentyuzet_GetListByUsb(int usbID)
        {
            List<Billentyuzet> ret = new List<Billentyuzet>();

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.billentyuzet.Where(i => i.usb_tipus_id == usbID);

                foreach (var item in query)
                {
                    ret.Add(new Billentyuzet {
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        ID = item.id,
                        NettoAr = item.netto_ar,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return ret;
        }

        public List<Billentyuzet> Billentyuzet_GetListPS2()
        {
            List<Billentyuzet> ret = new List<Billentyuzet>();

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.billentyuzet.Where(i => i.is_ps2_csatolo);

                foreach (var item in query)
                {
                    ret.Add(new Billentyuzet
                    {
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        ID = item.id,
                        NettoAr = item.netto_ar,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return ret;
        }

        public List<Eger> Eger_GetListByUsb(int usbID)
        {
            List<Eger> ret = new List<Eger>();

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.eger.Where(i => i.usb_tipus_id == usbID);

                foreach (var item in query)
                {
                    ret.Add(new Eger
                    {
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        ID = item.id,
                        NettoAr = item.netto_ar,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return ret;
        }

        public List<Eger> Eger_GetListPS2()
        {
            List<Eger> ret = new List<Eger>();

            using (var ctx = new ComputerStoreEntities())
            {
                var query = ctx.eger.Where(i => i.is_ps2_csatolo);

                foreach (var item in query)
                {
                    ret.Add(new Eger
                    {
                        Gyarto = item.alkatresz_gyarto.megnevezes,
                        ID = item.id,
                        NettoAr = item.netto_ar,
                        Megnevezes = item.megnevezes
                    });
                }
            }

            return ret;
        }

        public List<Szamitogephaz> SzamitogepHaz_GetList()
        {
            List<Szamitogephaz> ret = new List<Szamitogephaz>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.szamitogep_haz)
                {
                    ret.Add(new Szamitogephaz
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes,
                        NettoAr = item.netto_ar
                    });

                }
            }

            return ret;
        }

        public List<Tapegyseg> Tapegyseg_GetList()
        {
            List<Tapegyseg> ret = new List<Tapegyseg>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.tapegyseg)
                {
                    ret.Add(new Tapegyseg
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes,
                        NettoAr = item.netto_ar
                    });

                }
            }

            return ret;
        }

        public List<Monitor> Monitor_GetListByMeret(int meretID)
        {
            List<Monitor> ret = new List<Monitor>();

            using (var ctx = new ComputerStoreEntities())
            {
                foreach (var item in ctx.monitor.Where(i => i.monitor_meret_id == meretID))
                {
                    ret.Add(new Monitor
                    {
                        ID = item.id,
                        Megnevezes = item.megnevezes,
                        NettoAr = item.netto_ar
                    });

                }
            }

            return ret;
        }
    }
}
