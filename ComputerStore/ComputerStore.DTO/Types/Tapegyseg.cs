using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.DTO.Types
{
    [DataContract]
    public class Tapegyseg:Kategoria
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        [Display(Name = "Gyártó")]
        public string Gyarto { get; set; }

        [DataMember]
        [Display(Name = "Teljesítmény")]
        public int Teljesitmeny { get; set; }


        [DataMember]
        public Byte[] Kep { get; set; }

        [DataMember]
        public int Db { get; set; }

    }
}
