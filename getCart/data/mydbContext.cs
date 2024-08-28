using Microsoft.EntityFrameworkCore;
using getCart;

namespace getCart.Data
{
    public class mydbContext : DbContext
    {
        public mydbContext(DbContextOptions<mydbContext> options) : base(options) { }

        public DbSet<cartReq> cartInfo{get; set;}

    }
}