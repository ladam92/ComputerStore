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
    public class Videokartya:Kategoria
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        [Display(Name = "Gyártó")]
        public string Gyarto { get; set; }

        [DataMember]
        [Display(Name = "Memória típus")]
        public string MemoriaTipus { get; set; }

        [DataMember]
        public int MemoriaTipusID { get; set; }

        [DataMember]
        [Display(Name = "Memória (GB)")]
        public int MemoriaMeret { get; set; }


        [DataMember]
        public Byte[] Kep { get; set; }

        [DataMember]
        public int Db { get; set; }
    }
}
