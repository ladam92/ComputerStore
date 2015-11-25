using ComputerStore.DTO.Enums;
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
    public class Fokategoriatipus
    {
        [DataMember]
        [Display(Name = "Megnevezés")]
        public string Megnevezes { get; set; }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public Byte[] Kep { get; set; }

        [DataMember]
        public string Tipus
        {
            get;
            set;
        }
    }
}
