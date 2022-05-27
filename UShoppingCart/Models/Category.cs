﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UShoppingCart.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name="Display Orderd")]
        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Display order for category must be greater than 0")]
        public string DisplayOrder { get; set; }
    }
}
