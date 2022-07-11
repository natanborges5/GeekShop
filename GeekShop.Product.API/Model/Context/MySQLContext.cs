using Microsoft.EntityFrameworkCore;

namespace GeekShop.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Star Wars T-Shirt",
                Price = new decimal(45.90),
                Description = "T-Shirt from star wars 3",
                CategoryName = "T-Shirt",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQt8AlaT50V5rQ3BVke7N5i9uIdKT33YttRqw&usqp=CAU"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Star Wars Mug",
                Price = new decimal(20),
                Description = "Mug from star wars 3",
                CategoryName = "Mug",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRZskKDiff_gkQxZIvg3mdet_4LDc4xhydyVvhAlax70DHe2lsSoihORzDxa0AUiVIXhe4&usqp=CAU"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "The witcher sweatshirt",
                Price = new decimal(45.90),
                Description = "sweatshirt from The witcher 3",
                CategoryName = "Sweatshirt",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT5qqNlrE19euMsFW6ofy0F3ehjmtc7ujXoIQWLXEu8_2VO3Wvawj-LTD6QhKbSm1y6xHA&usqp=CAU"

            });
        } 
    }
}
