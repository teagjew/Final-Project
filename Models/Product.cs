using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Final_Project.Models
{
    public class Product
    {
        public int ProductId {get; set;}

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name {get; set;}

        [DataType(DataType.Currency)]
        public decimal Price {get; set;}

        public string Type {get; set;}

        public string Brand {get; set;}

        public List<Review> Reviews {get; set;}
    }
}