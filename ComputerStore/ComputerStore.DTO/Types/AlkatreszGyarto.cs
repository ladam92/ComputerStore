using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerStore.DTO.Enums;

namespace ComputerStore.DTO.Types
{
    public class AlkatreszGyarto : AlkatreszTipus
    {
        public override Kategoriak Tipus
        {
            get
            {
                return Kategoriak.AlkatreszGyarto;
            }
        }
    }
}
