﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ComputerStore.DTO.Enums;

namespace ComputerStore.DTO.Types
{
    [DataContract]
    public class MonitorFelbontas : AlkatreszTipus
    {
        public override Kategoriak Tipus
        {
            get
            {
                return Kategoriak.MonitorFelbontas;
            }
        }
    }
}
