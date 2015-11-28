using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Models
{
    public class AlaplapViewModel
    {

        public int Gyarto { get; set; }

        public string Foglalat { get; set; }

        public int FoglalatID { get; set; }

        public int PCIID { get; set; }

        public string PCI { get; set; }

        public int MemoriaFoglalatID { get; set; }

        public string MemoriaFoglalat { get; set; }

        [Display(Name = "Memória darabszám")]
        //[Required(ErrorMessage = "Memória darabszámot kötelező megadni!")]
        public int MemoriaDarab { get; set; }

        [Display(Name = "VGA darabszám")]
        //[Required(ErrorMessage = "VGA darabszámot kötelező megadni!")]
        public int VGADarab { get; set; }

        public bool IsPs2 { get; set; }

        [Display(Name = "Kép")]
        //[Required(ErrorMessage = "Képet kötelező megadni!")]
        public Byte[] Kep { get; set; }

        [Display(Name = "Darabszám")]
        //[Required(ErrorMessage = "Raktáron lévő darabszámot kötelező megadni!")]
        public int Db { get; set; }
   
        [Display(Name="Megnevezés")]
        //[Required(ErrorMessage = "Megnevezést kötelező megadni!")]
        public string Megnevezes { get; set; }

        [Display(Name = "Nettó ár")]
        //[Required(ErrorMessage = "Árat kötelező megadni!")]
        public decimal NettoAr { get; set; }

        public int USBID { get; set; }

        [Display(Name = "USB darabszám")]
        //[Required(ErrorMessage = "USB darabszámot kötelező megadni!")]
        public int USBdb { get; set; }

        public int HattertarCsatoloID { get; set; }

        [Display(Name = "Háttértár csatoló darabszám")]
        //[Required(ErrorMessage = "Háttértár csatoló darabszámot kötelező megadni!")]
        public int Hattertardb { get; set; }

        public int ID { get; set; }

        public string VGA { get; set; }

        public int VGAID { get; set; }

        public SelectList USBList { get; set; }

        public SelectList HattertarCsatoloList { get; set; }

        public SelectList AlkatreszGyarto { get; set; }

        public SelectList ProcFoglalat { get; set; }

        public SelectList MemoriaFoglalatList { get; set; }

        public SelectList VGACsatolo { get; set; }

        public SelectList PCIExpressz { get; set; }

    }
}