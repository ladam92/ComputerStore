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
    
    public partial class alaplap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public alaplap()
        {
            this.alaplap_hattertar = new HashSet<alaplap_hattertar>();
            this.alaplap_usb = new HashSet<alaplap_usb>();
        }
    
        public int id { get; set; }
        public int alkatresz_gyarto_id { get; set; }
        public int proc_foglalat_tipus_id { get; set; }
        public int memoria_foglalat_tipus_id { get; set; }
        public int vga_csatolo_felulet_tipus_id { get; set; }
        public Nullable<int> pci_express_tipus_id { get; set; }
        public int memoria_foglalat_darab { get; set; }
        public int vga_csatolo_darab { get; set; }
        public bool van_ps2_port { get; set; }
        public string megnevezes { get; set; }
        public string leiras { get; set; }
        public Nullable<int> kep_id { get; set; }
        public decimal netto_ar { get; set; }
        public Nullable<int> db { get; set; }
    
        public virtual alkatresz_gyarto alkatresz_gyarto { get; set; }
        public virtual kepek kepek { get; set; }
        public virtual memoria_foglalat_tipus memoria_foglalat_tipus { get; set; }
        public virtual pci_express_tipus pci_express_tipus { get; set; }
        public virtual proc_foglalat_tipus proc_foglalat_tipus { get; set; }
        public virtual vga_csatolo_felulet_tipus vga_csatolo_felulet_tipus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alaplap_hattertar> alaplap_hattertar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alaplap_usb> alaplap_usb { get; set; }
    }
}
