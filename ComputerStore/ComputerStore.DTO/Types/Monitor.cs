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
    public class Monitor:Kategoria
    {
        [DataMember]
        [Display(Name = "Gyártó")]
        public string Gyarto { get; set; }

        [DataMember]
        [Display(Name = "Felbontás")]
        public string Felbontas { get; set; }

        [DataMember]
        public int FelbontasID { get; set; }

        [DataMember]
        [Display(Name = "Méret")]
        public string Meret { get; set; }

        [DataMember]
        public int MeretID { get; set; }

        [DataMember]
        [Display(Name = "Csatlakozó felület")]
        public string Csatolo { get; set; }

        [DataMember]
        public int CsatoloID { get; set; }

    }
}
