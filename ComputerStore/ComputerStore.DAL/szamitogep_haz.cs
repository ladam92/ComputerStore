//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComputerStore.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class szamitogep_haz
    {
        public int id { get; set; }
        public int alkatresz_gyarto_id { get; set; }
        public string megnevezes { get; set; }
        public decimal netto_ar { get; set; }
        public Nullable<int> kep_id { get; set; }
    
        public virtual alkatresz_gyarto alkatresz_gyarto { get; set; }
        public virtual kepek kepek { get; set; }
    }
}
