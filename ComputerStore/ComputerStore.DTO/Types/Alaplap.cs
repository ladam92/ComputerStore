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
    public class Alaplap:Kategoria
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        [Display(Name = "Gyártó")]
        public string Gyarto { get; set; }

        [DataMember]
        [Display(Name = "Processzor foglalat")]
        public string Foglalat { get; set; }

        [DataMember]
        public int FoglalatID { get; set; }

        [DataMember]
        public int MemoriaFoglalatID { get; set; }

        [DataMember]
        [Display(Name = "Memória foglalat")]
        public string MemoriaFoglalat { get; set; }

        [DataMember]
        [Display(Name = "Memóriák száma")]
        public int MemoriaDarab { get; set; }

        [DataMember]
        [Display(Name = "Videókártyák száma")]
        public int VGADarab { get; set; }

        [DataMember]
        [Display(Name = "Ps/2 port")]
        public bool IsPs2 { get; set; }

        [DataMember]
        public string Leiras { get; set; }

        [DataMember]
        public Byte[] Kep { get; set; }

        [DataMember]
        [Display(Name = "Raktáron (db)")]
        public int Db { get; set; }
    }
}
