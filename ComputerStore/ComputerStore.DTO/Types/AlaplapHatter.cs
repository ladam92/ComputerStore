using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.DTO.Types
{
    [DataContract]
    public class AlaplapHatter
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int Alaplap_ID { get; set; }

        [DataMember]
        public int Csatolo_ID { get; set; }

        [DataMember]
        public int Darab { get; set; }
    }
}
