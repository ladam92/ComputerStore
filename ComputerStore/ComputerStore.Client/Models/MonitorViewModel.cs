using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Models
{
    public class MonitorViewModel
    {
        public int ID { get; set; }

        public int Gyarto { get; set; }

        public string Felbontas { get; set; }

        public int FelbontasID { get; set; }

        public string Meret { get; set; }

        public int MeretID { get; set; }

        public string Csatolo { get; set; }

        public int CsatoloID { get; set; }

        public Byte[] Kep { get; set; }

        public int Db { get; set; }

        public string Megnevezes { get; set; }

        public decimal NettoAr { get; set; }

        public SelectList AlkatreszGyarto { get; set; }

        public SelectList MonitorMeret { get; set; }

        public SelectList MonitorFelbontas { get; set; }

        public SelectList MonitorCsatolo { get; set; }
    }
}