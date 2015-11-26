using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerStore.Client.Models
{
    public class EgerViewModel
    {
        public int ID { get; set; }

        public int Gyarto { get; set; }

        public string Usb { get; set; }

        public int UsbID { get; set; }

        public bool IsPs2 { get; set; }

        public Byte[] Kep { get; set; }

        public int Db { get; set; }

        public string Megnevezes { get; set; }

        public decimal NettoAr { get; set; }

        public SelectList USBList { get; set; }

        public SelectList AlkatreszGyarto { get; set; }
    }
}