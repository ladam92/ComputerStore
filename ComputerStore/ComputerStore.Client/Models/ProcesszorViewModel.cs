using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Models
{
    public class ProcesszorViewModel
    {

        public int ID { get; set; }

        public int Gyarto { get; set; }

        public int Magok { get; set; }

        public decimal Frekvencia { get; set; }

        public string FrekvenciaMertek { get; set; }

        public int FrekvenciaMertekID { get; set; }

        public string ProcFoglalat { get; set; }

        public int ProcFoglalatID { get; set; }

        public Byte[] Kep { get; set; }

        public int Db { get; set; }

        public string Megnevezes { get; set; }

        public decimal NettoAr { get; set; }

        public SelectList AlkatreszGyarto { get; set; }

        public SelectList ProcFoglalatList { get; set; }

        public SelectList FrekvenciaMertekList { get; set; }

    }
}