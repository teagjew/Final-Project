using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
	public class ProductContext : DbContext
	{
		public ProductContext (DbContextOptions<ProductContext> options)
			: base(options)
		{
		}
        public DbSet<Product> Product {get; set;}
		public DbSet<Review> Review {get; set;}
	}
}