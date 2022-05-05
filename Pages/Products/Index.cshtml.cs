using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Final_Project.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Final_Project.Models.ProductContext _context;

        public IndexModel(Final_Project.Models.ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;        

        // Sorting support
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}
        // Second sorting technique with a SelectList
        public SelectList SortList {get; set;}

        [BindProperty(SupportsGet = true)]
        public string Search {get; set;}

        public async Task OnGetAsync()
        {
            var query = _context.Product.Select(p => p);
            List<SelectListItem> sortItems = new List<SelectListItem> {
                new SelectListItem { Text = "Price Low to High", Value = "price_asc" },
                new SelectListItem { Text = "Price High to Low", Value = "price_desc"}
            };
            SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

            if (Search != null)
            {
                query = query.Where(p => p.Name.Contains(Search) || p.Brand.Contains(Search) || p.Type.Contains(Search));
            }

            switch (CurrentSort)
            {
                case "price_asc": 
                    query = query.OrderBy(p => p.Price);
                    break;
                case "price_desc":
                    query = query.OrderByDescending(p => p.Price);
                    break;
            }

            Product = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
