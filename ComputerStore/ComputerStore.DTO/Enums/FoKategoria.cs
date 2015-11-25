using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.DTO.Enums
{
    public enum FoKategoria
    {
        [Display(Name = "Alaplap")]
        Alaplap = 1,
        [Display(Name = "Billentyűzet")]
        Billentyuzet = 2,
        [Display(Name = "Egér")]
        Eger = 3,
        [Display(Name = "Hattértár")]
        Hattertar = 4,
        [Display(Name = "Memória")]
        Memoria = 5,
        [Display(Name = "Monitor")]
        Monitor = 6,
        [Display(Name = "Processzor")]
        Processzor = 7,
        [Display(Name = "Számítógépház")]
        Szamitogephaz = 8,
        [Display(Name = "Tápegység")]
        Tapegyseg = 9,
        [Display(Name = "Videókártya")]
        Videokartya = 10
    }
}
