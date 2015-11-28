using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.DTO.Types
{
    [DataContract]
    public class Processzor:Kategoria
    {
        [DataMember]
        public string Gyarto { get; set; }


        [DataMember]
        public int Magok { get; set; }

        [DataMember]
        public decimal Frekvencia { get; set; }

        [DataMember]
        public string FrekvenciaMertek { get; set; }

        [DataMember]
        public int FrekvenciaMertekID { get; set; }

        [DataMember]
        public string ProcFoglalat { get; set; }

        [DataMember]
        public int ProcFoglalatID { get; set; }
    }
}
