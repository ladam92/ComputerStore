using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.DTO.Types
{
    [DataContract]
    public class VideokartyaMon
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int VideokartyaID { get; set; }

        [DataMember]
        public int CsatoloID { get; set; }

        [DataMember]
        public int Darab { get; set; }

    }
}
