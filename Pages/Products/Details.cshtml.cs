using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;


namespace Final_Project.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly ILogger<DetailsModel> _logger;

        private readonly Final_Project.Models.ProductContext _context;

        public DetailsModel(Final_Project.Models.ProductContext context, ILogger<DetailsModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public Product Product { get; set; }
        [BindProperty]
        public int ReviewToDelete {get; set;}

        [BindProperty]
        public int ProductToReview {get; set;}

        [BindProperty]
        [Required]
        [Display(Name = "Name")]
        public string CustomerName {get; set;}

        [BindProperty]
        [Required]
        [StringLength(200)]
        [Display(Name = "Review")]
        public string NewReview {get; set;}

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product.Include(p => p.Reviews).FirstOrDefaultAsync(m => m.ProductId == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPostDeleteReview(int? id)
        {
            /* if (!ModelState.IsValid)
            {
                return Page();
            } */

            // Find the review in the database
            Review Review = _context.Review.FirstOrDefault(r => r.ReviewId == ReviewToDelete);
            
            if (Review != null)
            {
                _context.Remove(Review); // Delete the review
                _context.SaveChanges();
            }

            Product = _context.Product.Include(p => p.Reviews).FirstOrDefault(p => p.ProductId == id);

            return Page();
        }

        public IActionResult OnPostAddReview(int? id)
        {
            /* if (!ModelState.IsValid)
            {
                return Page();
            } */

            Review ReviewToAdd = new Review {Comment = NewReview, 
                        CustomerName = CustomerName,
                        Date = DateTime.Now,
                        ProductID = ProductToReview};

            _context.Review.Add(ReviewToAdd);
            _context.SaveChanges();

            Product = _context.Product.Include(p => p.Reviews).FirstOrDefault(p => p.ProductId == id);

            return Page();
        }
    }
}
