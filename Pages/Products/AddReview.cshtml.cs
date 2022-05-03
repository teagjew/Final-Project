using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Final_Project.Pages
{
    public class AddReviewModel : PageModel
    {
        private readonly ILogger<AddReviewModel> _logger;
        private readonly ProductContext _context; // Movie Database context
        [BindProperty]
        public Review Review {get; set;}
        public SelectList ProductsDropDown {get; set;}

        public AddReviewModel(ProductContext context, ILogger<AddReviewModel> logger)
        {
            // Bring in Database context and logger using dependency injection
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            ProductsDropDown = new SelectList(_context.Product.ToList(), "ProductID", "Name");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Review.Add(Review);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}