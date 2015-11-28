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
    public class Billentyuzet:Kategoria
    {
        [DataMember]
        [Display(Name = "Gyártó")]
        public string Gyarto { get; set; }

        [DataMember]
        public int UsbID { get; set; }

        [DataMember]
        [Display(Name = "USB típus")]
        public string Usb { get; set; }

        [DataMember]
        [Display(Name = "PS/2 port")]
        public bool IsPs2 { get; set; }

    }
}
