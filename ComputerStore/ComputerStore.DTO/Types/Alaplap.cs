﻿using System;
using System.Collections.Generic;
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
        public string Gyarto { get; set; }

        [DataMember]
        public int FoglalatID { get; set; }

        [DataMember]
        public int MemoriaFoglalatID { get; set; }

        [DataMember]
        public string MemoriaFoglalat { get; set; }

        [DataMember]
        public int MemoriaDarab { get; set; }

        [DataMember]
        public int VGADarab { get; set; }

        [DataMember]
        public bool IsPs2 { get; set; }

        [DataMember]
        public string Leiras { get; set; }

        [DataMember]
        public Byte[] Kep { get; set; }

        [DataMember]
        public int Db { get; set; }
    }
}
