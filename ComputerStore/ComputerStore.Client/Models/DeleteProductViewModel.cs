using ComputerStore.DTO.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComputerStore.Client.Models
{
    public class DeleteProductViewModel
    {
        [Display(Name = "Főkategória")]
        public FoKategoria Tipus { get; set; }
    }
}