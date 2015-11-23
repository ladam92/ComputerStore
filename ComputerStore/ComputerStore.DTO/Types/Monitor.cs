using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.DTO.Types
{
    [DataContract]
    public class Monitor:Kategoria
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Gyarto { get; set; }

        [DataMember]
        public int FelbontasID { get; set; }

        [DataMember]
        public int MeretID { get; set; }

        [DataMember]
        public int CsatoloID { get; set; }


        [DataMember]
        public Byte[] Kep { get; set; }

        [DataMember]
        public int Db { get; set; }

    }
}
