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
    public class Hattertar:Kategoria
    {

        [DataMember]
        [Display(Name = "Gyártó")]
        public string Gyarto { get; set; }

        [DataMember]
        [Display(Name = "Típus")]
        public string Tipus { get; set; }

        [DataMember]
        public int TipusID { get; set; }

        [DataMember]
        [Display(Name = "Csatoló felület")]
        public string Csatolo { get; set; }

        [DataMember]
        public int CsatoloID { get; set; }

        [DataMember]
        [Display(Name = "Kapacitás (Gb)")]
        public int Meret { get; set; }
    }
}
