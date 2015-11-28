
using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CoputerStore.BL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILogic
    {
        [OperationContract]
        AlaplapUSB USBGetByAlaplapID(int id);

        [OperationContract]
        AlaplapHatter HattertarGetByAlaplapID(int id);

        [OperationContract]
        VideokartyaMon MonitorcsatoloGetByVideokartyaID(int id);

        [OperationContract]
        void InsertingVideokartyaDB(int csatolo_id, int mondb, int gyarto_id, int memoria_id, string megnev, int ar, int db, int meret, Byte[] kep);

        [OperationContract]
        void InsertingTapegysegDB(int gyarto_id, string megnev, int ar, int db, int telj, Byte[] kep);

        [OperationContract]
        void InsertingSzamitogephazDB(int gyarto_id, string megnev, int ar, int db, Byte[] kep);

        [OperationContract]
        void InsertingProcesszorDB(int gyarto_id, int foglalat_id, string meg, int ar, int db, int magok, int frekvencia, Byte[] kep);

        [OperationContract]
        void InsertingMonitorDB(int gyarto_id, int csatolo_id, int felbontas_id, int meret_id, string megnev, int ar, int db, Byte[] kep);

        [OperationContract]
        void InsertingMemoriaDB(int gyarto_id, int foglalat_id, string megnevezes, int ar, int db, int meret, Byte[] kep);

        [OperationContract]
        void InsertingEgerDB(int gyarto_id, int usb_id, bool ps2, string megnevezes, int ar, int db, Byte[] kep);

        [OperationContract]
        void InsertingHattertarDB(int gyarto_id, int csatolo_id, int tipus_id, string megnevezes, int ar, int db, int meret, Byte[] kep);

        [OperationContract]
        void InsertingBillentyuzetDB(int gyarto_id, int usb_id, bool ps2, string megnevezes, int ar, int db, Byte[]kep);

        [OperationContract]
        void InsertingAlaplapDB(int usb_id, int hattertar_id, int gyarto_id, int foglalat_id, int memoria_id, int vga_id, int pci_id, int mem_db, int vga_db, bool ps2, string megnevezes, int ar, int db, Byte[] kep, int hatdb, int usbdb);

        [OperationContract]
        void InsertKep(Byte[] kep);

        [OperationContract]
        void InsertVideokartya(int csatolo_id, int csatdb, int id, int gyarto_id, int memoria_id, string megnev, int ar, int db, int meret);

        [OperationContract]
        void InsertTapegyseg(int id, int gyarto_id, string megnev, int ar, int db, int telj);

        [OperationContract]
        void InsertSzamitogephaz(int id, int gyarto_id, string megnev, int ar, int db);

        [OperationContract]
        void InsertMonitor(int id, int gyarto_id, int csatolo_id, int felbontas_id, int meret_id, string megnev, int ar, int db);

        [OperationContract]
        void InsertMemoria(int id, int gyarto_id, int foglalat_id, string megnevezes, int ar, int db, int meret);

        [OperationContract]
        void InsertHattertar(int id, int gyarto_id, int csatolo_id, int tipus_id, string megnevezes, int ar, int db, int meret);

        [OperationContract]
        void InsertEger(int id, int gyarto_id, int usb_id, bool ps2, string megnevezes, int ar, int db);

        [OperationContract]
        void InsertCPU(int id, int gyarto_id, int foglalat_id, string meg, int ar, int db, int magok, int frekvencia);

        [OperationContract]
        void InsertBillentyuzet(int id, int gyarto_id, int usb_id, bool ps2, string megnevezes, int ar, int db);

        [OperationContract]
        List<MonitorCsatoloTipus> MonitorCsatoloTipusGet();

        [OperationContract]
        List<MonitorFelbontas> MonitorFelbontasGet();
        
        [OperationContract]
        List<MonitorMeret> MonitorMeretGet();

        [OperationContract]
        List<HattertarCsatoloTipus> HattertarCsatoloTipusGet();

        [OperationContract]
        List<HattertarTipus> HattertarTipusGet();

        [OperationContract]
        List<UsbTipus> UsbGet();

        [OperationContract]
        void InsertAlaplap(int csatolo_id, int usb_id, int usbdb, int hatdb, int id, int gyarto_id, int foglalat_id, int memoria_id, int vga_id, int pci_id, int mem_db, int vga_db, bool ps2, string megnevezes, int ar, int db);

        [OperationContract]
        List<PciExpressTipus> PciGet();

        [OperationContract]
        List<VgaCsatoloFeluletTipus> VgaGet();

        [OperationContract]
        List<MemoriaTipus> MemoriaGet();

        [OperationContract]
        List<ProcesszorFoglalatTipus> ProcesszorGet();

        [OperationContract]
        List<AlkatreszGyarto> GyartoGet();

        [OperationContract]
        List<Fokategoriatipus> GetAlaplap();

        [OperationContract]
        List<Fokategoriatipus> GetBillentyuzet();

        [OperationContract]
        List<Fokategoriatipus> GetEger();

        [OperationContract]
        List<Fokategoriatipus> GetHattertar();

        [OperationContract]
        List<Fokategoriatipus> GetMemoria();

        [OperationContract]
        List<Fokategoriatipus> GetMonitor();

        [OperationContract]
        List<Fokategoriatipus> GetProcesszor();

        [OperationContract]
        List<Fokategoriatipus> GetSzamitogephaz();

        [OperationContract]
        List<Fokategoriatipus> GetTapegyseg();

        [OperationContract]
        List<Fokategoriatipus> GetVideokartya();

        [OperationContract]
        List<ProcesszorFoglalatTipus> ProcFoglalat_GetKategoriak();

        [OperationContract]
        List<ProcesszorFoglalatTipus> ProcFoglalat_GetKategoriakByName(string name);

        [OperationContract]
        ProcesszorFoglalatTipus ProcFoglalat_GetKategoriaByID(int id);

        [OperationContract]
        void ProcFoglalat_Update(ProcesszorFoglalatTipus type);

        [OperationContract]
        void ProcFoglalat_Add(ProcesszorFoglalatTipus type);

        [OperationContract]
        List<MemoriaTipus> MemoriaFoglalat_GetKaegoriak();

        [OperationContract]
        List<MemoriaTipus> MemoriaFoglalat_GetKaegoriakByName(string name);

        [OperationContract]
        MemoriaTipus MemoriaFoglalat_GetKategoriaByID(int id);

        [OperationContract]
        void MemoriaFoglalat_Update(MemoriaTipus type);

        [OperationContract]
        void MemoriaFoglalat_Add(MemoriaTipus type);

        [OperationContract]
        List<UsbTipus> UsbTipus_GetKaegoriak();

        [OperationContract]
        List<UsbTipus> UsbTipus_GetKaegoriakByName(string name);

        [OperationContract]
        void UsbTipus_Update(UsbTipus type);

        [OperationContract]
        void UsbTipus_Add(UsbTipus type);

        [OperationContract]
        UsbTipus UsbTipus_GetKategoriaByID(int id);

        [OperationContract]
        List<HattertarTipus> HattertatTipus_GetKaegoriak();

        [OperationContract]
        List<HattertarTipus> HattertatTipus_GetKaegoriakByName(string name);

        [OperationContract]
        HattertarTipus HattertatTipus_GetKategoriaByID(int id);

        [OperationContract]
        void HattertatTipus_Update(HattertarTipus type);

        [OperationContract]
        void HattertatTipus_Add(HattertarTipus type);

        [OperationContract]
        List<HattertarCsatoloTipus> HattertatCsatoloTipus_GetKaegoriak();

        [OperationContract]
        List<HattertarCsatoloTipus> HattertatCsatoloTipus_GetKaegoriakByName(string name);

        [OperationContract]
        HattertarCsatoloTipus HattertatCsatoloTipus_GetKategoriaByID(int id);

        [OperationContract]
        void HattertatCsatoloTipus_Update(HattertarCsatoloTipus type);

        [OperationContract]
        void HattertatCsatoloTipus_Add(HattertarCsatoloTipus type);

        [OperationContract]
        List<MonitorFelbontas> MonitorFelbontasTipus_GetKaegoriak();

        [OperationContract]
        List<MonitorFelbontas> MonitorFelbontasTipus_GetKaegoriakByName(string felbontas);

        [OperationContract]
        MonitorFelbontas MonitorFelbontasTipus_GetKategoriaByID(int id);

        [OperationContract]
        void MonitorFelbontasTipus_Update(MonitorFelbontas type);

        [OperationContract]
        void MonitorFelbontasTipus_Add(MonitorFelbontas type);

        [OperationContract]
        List<MonitorMeret> MonitorMeretTipus_GetKaegoriak();

        [OperationContract]
        List<MonitorMeret> MonitorMeretTipus_GetKaegoriakByName(string meret);

        [OperationContract]
        MonitorMeret MonitorMeretTipus_GetKategoriaByID(int id);

        [OperationContract]
        void MonitorMeretTipus_Update(MonitorMeret meret);

        [OperationContract]
        void MonitorMeretTipus_Add(MonitorMeret meret);

        [OperationContract]
        PageableList<Alaplap> Alaplap_GetByFoglalatID(int id, int pageNumber, int pageSize);

        [OperationContract]
        List<Alaplap> Alaplap_GetListByFoglalatID(int id);

        [OperationContract]
        PageableList<Alaplap> Alaplap_GetByMemoriaID(int id, int pageNumber, int pageSize);

        [OperationContract]
        PageableList<Billentyuzet> Billentyuzet_GetByUsbID(int id, int pageNumber, int pageSize);

        [OperationContract]
        PageableList<Billentyuzet> Billentyuzet_GetByPs( int pageNumber, int pageSize);

        [OperationContract]
        PageableList<Eger> Eger_GetByUsbID(int id, int pageNumber, int pageSize);

        [OperationContract]
        PageableList<Eger> Eger_GetByPs(int pageNumber, int pageSize);

        [OperationContract]
        PageableList<Hattertar> Hattertar_GetByHattertarTipus(int id, int pageNumber, int pageSize);

        [OperationContract]
        PageableList<Hattertar> Hattertar_GetByHattertarCsatolo(int id, int pageNumber, int pageSize);

        [OperationContract]
        PageableList<Memoria> Memoria_GetByFoglalat(int id, int pageNumber, int pageSize);

        [OperationContract]
        List<Memoria> Memoria_GetListByFoglalat(int id);

        [OperationContract]
        PageableList<Monitor> Monitor_GetByMeret(int id, int pageNumber, int pageSize);

        [OperationContract]
        PageableList<Monitor> Monitor_GetByFelbontas(int id, int pageNumber, int pageSize);

        [OperationContract]
        PageableList<Processzor> Processzor_GetByFoglalat(int id, int pageNumber, int pageSize);

        [OperationContract]
        List<Processzor> Processzor_GetListByFoglalat(int id);

        [OperationContract]
        PageableList<Szamitogephaz> Szamitogephaz_Get(int pageNumber, int pageSize);

        [OperationContract]
        PageableList<Tapegyseg> Tapegyseg_Get(int pageNumber, int pageSize);

        [OperationContract]
        PageableList<Videokartya> Videokartya_Get(int pageNumber, int pageSize);


        [OperationContract]

        List<PciExpressTipus> PCIExpress_GetByName(string name);

        [OperationContract]
        PciExpressTipus PCIExpress_GetByID(int id);

        [OperationContract]
        void PCIExpress_Update(PciExpressTipus type);

        [OperationContract]
        void PCIExpress_Add(PciExpressTipus type);

        [OperationContract]
        List<ProcesszorFoglalatTipus> ProcesszorFoglalat_GetByName(string name);

        [OperationContract]
        ProcesszorFoglalatTipus ProcesszorFoglalat_GetByID(int id);

        [OperationContract]
        List<VgaCsatoloFeluletTipus> VgaCsatolo_GetByName(string name);

        [OperationContract]
        VgaCsatoloFeluletTipus VgaCsatolo_GetByID(int id);

        [OperationContract]
        void VgaCsatolo_Update(VgaCsatoloFeluletTipus type);

        [OperationContract]
        void VgaCsatolo_Add(VgaCsatoloFeluletTipus type);

        [OperationContract]
        List<AlkatreszGyarto> Gyarto_GetByName(string name);

        [OperationContract]
        AlkatreszGyarto Gyarto_GetByID(int id);

        [OperationContract]
        void Gyarto_Update(AlkatreszGyarto type);

        [OperationContract]
        void Gyarto_Add(AlkatreszGyarto type);

        [OperationContract]
        List<MonitorCsatoloTipus> MonitorCsatolo_GetByName(string name);

        [OperationContract]
        MonitorCsatoloTipus MonitorCsatolo_GetByID(int id);

        [OperationContract]
        void MonitorCsatolo_Update(MonitorCsatoloTipus type);

        [OperationContract]
        void MonitorCsatolo_Add(MonitorCsatoloTipus type);

        [OperationContract]
        Alaplap Alaplap_GetByID(int id);

        [OperationContract]
        Billentyuzet Billentyuzet_GetByID(int id);

        [OperationContract]
        Eger Eger_GetByID(int id);

        [OperationContract]
        Hattertar Hattertar_GetByID(int id);

        [OperationContract]
        Memoria Memoria_GetByID(int id);

        [OperationContract]
        Monitor Monitor_GetByID(int id);

        [OperationContract]
        Processzor Processzor_GetByID(int id);

        [OperationContract]
        Szamitogephaz Szamitogephaz_GetByID(int id);

        [OperationContract]
        Tapegyseg Tapegyseg_GetByID(int id);

        [OperationContract]
        Videokartya Videokartya_GetByID(int id);

        [OperationContract]
        List<Videokartya> Videokartya_GetList();

        [OperationContract]
        void DeleteAlaplap(int id);

        [OperationContract]
        void DeleteBillentyuzet(int id);

        [OperationContract]
        void DeleteEger(int id);

        [OperationContract]
        void DeleteHattertar(int id);

        [OperationContract]
        void DeleteMemoria(int id);

        [OperationContract]
        void DeleteMonitor(int id);

        [OperationContract]
        void DeleteProcesszor(int id);

        [OperationContract]
        void DeleteSzamitogephaz(int id);

        [OperationContract]
        void DeleteTapegyseg(int id);

        [OperationContract]
        void DeleteVideokartya(int id);

        [OperationContract]
        List<Hattertar> Hattertar_GetListByAlaplapAndTipus(int alaplapId, int tipus);

        [OperationContract]
        List<UsbTipus> Alaplap_GetUsbTipusok(int alaplapID);

        [OperationContract]
        List<Billentyuzet> Billentyuzet_GetListByUsb(int usbID);

        [OperationContract]
        List<Billentyuzet> Billentyuzet_GetListPS2();

        [OperationContract]
        List<Eger> Eger_GetListByUsb(int usbID);

        [OperationContract]
        List<Eger> Eger_GetListPS2();

        [OperationContract]
        List<Szamitogephaz> SzamitogepHaz_GetList();

        [OperationContract]
        List<Tapegyseg> Tapegyseg_GetList();

        [OperationContract]
        List<Monitor> Monitor_GetListByMeret(int meretID);

        [OperationContract]
        void Gyarto_Delete(int id);

        [OperationContract]
        void HattertatCsatoloTipus_Delete(int id);

        [OperationContract]
        void HattertarTipus_Delete(int id);

        [OperationContract]
        void MemoriaFoglalat_Delete(int id);

        [OperationContract]
        void MonitorFelbontasTipus_Delete(int id);

        [OperationContract]
        void MonitorMeretTipus_Delete(int id);

        [OperationContract]
        void PCIExpress_Delete(int id);

        [OperationContract]
        void ProcesszorFoglalat_Delete(int id);

        [OperationContract]
        void UsbTipus_Delete(int id);

        [OperationContract]
        void VgaCsatolo_Delete(int id);

        [OperationContract]
        void MonitorCsatolo_Delete(int id);
    }
}
