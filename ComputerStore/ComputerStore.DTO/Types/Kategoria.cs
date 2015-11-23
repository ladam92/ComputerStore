using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.DTO.Types
{
    [DataContract]
    public class Kategoria
    {
        [DataMember]
        public string Megnevezes { get; set; }

        [DataMember]
        public decimal NettoAr { get; set; }

        [DataMember]
        public int Db { get; set; }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public Byte[] Kep { get; set; }
    }
}
