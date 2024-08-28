using Microsoft.EntityFrameworkCore;
using getOrder;

namespace getOrder.Data
{
    public class mydbContext : DbContext
    {
        public mydbContext(DbContextOptions<mydbContext> options) : base(options) { }

        public DbSet<orderReq> orderInfo{get; set;}

    }
}
