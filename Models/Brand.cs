using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Final_Project.Models
{
    public class Brand
    {
        public int BrandId {get; set;}

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name {get; set;}

        public List<Product> Products {get; set;}
    }
}