using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Models
{
    public class HattertarViewModel
    {
        public int ID { get; set; }

        public int Gyarto { get; set; }

        public string Tipus { get; set; }

        public int TipusID { get; set; }

        public string Csatolo { get; set; }

        public int CsatoloID { get; set; }

        public int Meret { get; set; }

        public Byte[] Kep { get; set; }

        public int Db { get; set; }

        public string Megnevezes { get; set; }

        public decimal NettoAr { get; set; }

        public SelectList AlkatreszGyarto { get; set; }

        public SelectList HattertarTipus { get; set; }

        public SelectList HattertarCsatoloTipus { get; set; }
    }
}