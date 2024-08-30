using Microsoft.EntityFrameworkCore;
using getProduct;
using getProductReq;

namespace getProduct.Data
{
    public class mydbContext : DbContext
    {
        public mydbContext(DbContextOptions<mydbContext> options) : base(options) { }

        public DbSet<productReq> prodInfo{get; set;}

    }
}
