using Microsoft.EntityFrameworkCore;
using tiendung99.Ecommerce.DAL.Entities;

namespace tiendung99.Ecommerce.DAL.Data
{
    public class AppcationDbContext : DbContext
    {

        public AppcationDbContext(DbContextOptions<AppcationDbContext> options) : base(options)
        {

        }

        DbSet<Category> Categories { get; set; }
        DbSet<Image> Images { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Promotion> Promotions { get; set; }

    }
}
