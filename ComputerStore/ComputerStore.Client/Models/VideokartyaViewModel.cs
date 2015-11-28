using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Models
{
    public class VideokartyaViewModel
    {
        public int ID { get; set; }

        public int Gyarto { get; set; }

        public string MemoriaTipus { get; set; }

        public int MemoriaTipusID { get; set; }

        public int MemoriaMeret { get; set; }

        public Byte[] Kep { get; set; }

        public int Db { get; set; }

        public int MonitorCsatoloID { get; set; }

        public int Csatolodb { get; set; }

        public string Megnevezes { get; set; }

        public decimal NettoAr { get; set; }

        public SelectList AlkatreszGyarto { get; set; }

        public SelectList MemoriaTipusList { get; set; }

        public SelectList MonitorCsatoloList { get; set; }
    }
}