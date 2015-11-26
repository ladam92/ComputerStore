using System;
using System.Collections.Generic;
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

        public int MemoriaDarab { get; set; }

        public int VGADarab { get; set; }

        public bool IsPs2 { get; set; }

        public string Leiras { get; set; }

        public Byte[] Kep { get; set; }

        public int Db { get; set; }
   
        public string Megnevezes { get; set; }

        public decimal NettoAr { get; set; }

        public int ID { get; set; }

        public string VGA { get; set; }

        public int VGAID { get; set; }

        public SelectList AlkatreszGyarto { get; set; }

        public SelectList ProcFoglalat { get; set; }

        public SelectList MemoriaFoglalatList { get; set; }

        public SelectList VGACsatolo { get; set; }

        public SelectList PCIExpressz { get; set; }

    }
}