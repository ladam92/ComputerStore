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
    
    public partial class hattertar
    {
        public int id { get; set; }
        public int alkatresz_gyarto_id { get; set; }
        public int hattertar_tipus_id { get; set; }
        public int hattertar_csatolo_tipus_id { get; set; }
        public int meret_gb { get; set; }
        public string megnevezes { get; set; }
        public int netto_ar { get; set; }
        public Nullable<int> kep_id { get; set; }
        public Nullable<int> db { get; set; }
    
        public virtual alkatresz_gyarto alkatresz_gyarto { get; set; }
        public virtual hattertar_tipus hattertar_tipus { get; set; }
        public virtual hattertarolo_csatolo_tipus hattertarolo_csatolo_tipus { get; set; }
        public virtual kepek kepek { get; set; }
    }
}
