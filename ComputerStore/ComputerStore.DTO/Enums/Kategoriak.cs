using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.DTO.Enums
{
    public enum Kategoriak
    {
        [Display(Name = "Alkatrész gyártó")]
        AlkatreszGyarto = 1,
        [Display(Name = "Háttértár típus")]
        HattertarTipus = 2,
        [Display(Name = "Háttértár csatlakozó típus gyártó")]
        HattertarCsatoloTipus = 3,
        [Display(Name = "Memória foglalat")]
        MemoriaFoglalat = 4,
        [Display(Name = "Monitor felbontás")]
        MonitorFelbontas = 5,
        [Display(Name = "Monitor méret")]
        MonitorMeret = 6,
        [Display(Name = "PCI Express")]
        PciExpress = 7,
        [Display(Name = "Processzor foglalat")]
        ProcFoglalat = 8,
        [Display(Name = "USB típus")]
        USB = 9,
        [Display(Name = "Videókártya csatlakozó felület")]
        VGACsatolo = 10
    }
}
