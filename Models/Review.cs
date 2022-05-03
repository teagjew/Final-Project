using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class Review
    {
        public int ReviewId {get; set;}

        [Required]
        [StringLength(250, MinimumLength = 3)]
        public string Comment {get; set;}

        public string CustomerName {get; set;}

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date {get; set;}

        [Display(Name = "Product")]
        [Required]
        public int ProductID {get; set;}
        public Product Product {get; set;}
    }
}