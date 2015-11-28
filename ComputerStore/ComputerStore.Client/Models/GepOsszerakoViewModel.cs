using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerStore.Client.Models
{
    public class GepOsszerakoViewModel
    {
        public Alaplap Alaplap { get; set; }
        public List<Processzor> ProcesszorList { get; set; }
        public List<Memoria> MemoriaList { get; set; }
        public List<Videokartya> VideoKartyaList { get; set; }
        public List<UsbTipus> UsbTipusList { get; set; }
        public List<Tapegyseg> TapegysegList { get; set; }
        public List<Szamitogephaz> SzamitogephazList { get; set; }
    }
}