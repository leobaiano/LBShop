using Microsoft.EntityFrameworkCore;

namespace LBShop.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Caneca 5",
                Price = "9,70",
                CategoryName = "Canecas",
                Description = "Descrição",
                ImageURL = "Imagem URL"
            });
             modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Caneca 5",
                Price = "9,70",
                CategoryName = "Canecas",
                Description = "Descrição",
                ImageURL = "Imagem URL"
            });
             modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "Caneca 5",
                Price = "9,70",
                CategoryName = "Canecas",
                Description = "Descrição",
                ImageURL = "Imagem URL"
            });
             modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 31,
                Name = "Caneca 5",
                Price = "9,70",
                CategoryName = "Canecas",
                Description = "Descrição",
                ImageURL = "Imagem URL"
            });
             modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 41,
                Name = "Caneca 5",
                Price = "9,70",
                CategoryName = "Canecas",
                Description = "Descrição",
                ImageURL = "Imagem URL"
            });

        }

    }
}
