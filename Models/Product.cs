using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class Product
    {
        public int ProductId {get; set;}

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name {get; set;}

        public double Price {get; set;}

        public string Type {get; set;}

        [Required]
        public int BrandID {get; set;}
        public Brand Brand {get; set;}
    }
}