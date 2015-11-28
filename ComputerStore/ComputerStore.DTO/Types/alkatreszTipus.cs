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
    public class AlkatreszTipus
    {
        [DataMember]
        [Display(Name = "Megnevezés")]
        [Required(ErrorMessage ="Kötelező a megnevezést megadni!")]
        public string Megnevezes { get; set; }

        [DataMember]
        public int ID { get; set; }

        public virtual Kategoriak Tipus
        {
            get;
            set;
        }
    }
}
