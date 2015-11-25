using ComputerStore.DTO.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComputerStore.Client.Models
{
    public class CreateCategoryViewModel
    {
        [Display(Name="Megnevezés")]
        public string Megnevezes { get; set; }

        [Display(Name = "Kategória")]
        public Kategoriak Tipus { get; set; }
    }
}