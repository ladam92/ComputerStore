using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Models
{
    public class MemoriaViewModel
    {

        public int ID { get; set; }

        public int Gyarto { get; set; }

        public string Foglalat { get; set; }

        public int FoglalatID { get; set; }

        public int MemoriaMeret { get; set; }

        public Byte[] Kep { get; set; }

        public int Db { get; set; }

        public string Megnevezes { get; set; }

        public decimal NettoAr { get; set; }

        public SelectList AlkatreszGyarto { get; set; }

        public SelectList MemoriaFoglalatTipus { get; set; }
    }
}