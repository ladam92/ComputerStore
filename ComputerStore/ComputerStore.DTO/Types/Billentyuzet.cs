using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.DTO.Types
{
    [DataContract]
    public class Billentyuzet
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Gyarto { get; set; }

        [DataMember]
        public int UsbID { get; set; }

        [DataMember]
        public bool IsPs2 { get; set; }

        [DataMember]
        public string Megnevezes { get; set; }

        [DataMember]
        public Byte[] Kep { get; set; }

        [DataMember]
        public decimal NettoAr { get; set; }


    }
}
