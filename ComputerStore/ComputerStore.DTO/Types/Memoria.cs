using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.DTO.Types
{
    [DataContract]
    public class Memoria:Kategoria
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Gyarto { get; set; }

        [DataMember]
        public int FoglalatID { get; set; }

        [DataMember]
        public int MemoriaMeret { get; set; }


        [DataMember]
        public Byte[] Kep { get; set; }

        [DataMember]
        public int Db { get; set; }

    }
}
