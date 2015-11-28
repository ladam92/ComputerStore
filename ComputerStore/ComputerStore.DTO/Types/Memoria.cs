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
    public class Memoria:Kategoria
    {
        [DataMember]
        [Display(Name = "Gyártó")]
        public string Gyarto { get; set; }
        
        [DataMember]
        [Display(Name = "Foglalat típusa")]
        public string Foglalat { get; set; }

        [DataMember]
        public int FoglalatID { get; set; }

        [DataMember]
        [Display(Name = "Kapacitás (GB)")]
        public int MemoriaMeret { get; set; }

    }
}
