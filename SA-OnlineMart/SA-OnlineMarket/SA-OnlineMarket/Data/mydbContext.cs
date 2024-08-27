using Microsoft.EntityFrameworkCore;
using SA_OnlineMarket.Models;


namespace SA_OnlineMarket.Data
{
    public class mydbContext : DbContext
    {
        public mydbContext(DbContextOptions<mydbContext> options) : base(options) { }
        public DbSet<getProducts> prodInfo { get; set; }
        public DbSet<getLogin> userInfo { get;set; }
        public DbSet<getCart> cartInfo { get; set; }
        public DbSet<getNewProduct> newProductInfo { get; set; }
        public DbSet<getOrder> orderInfo { get; set; }
        public DbSet<getShipment> shipmentInfo { get; set; }
    }
}
