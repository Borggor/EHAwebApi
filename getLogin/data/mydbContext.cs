using Microsoft.EntityFrameworkCore;
using getLogin;

namespace getOrder.Data
{
    public class mydbContext : DbContext
    {
        public mydbContext(DbContextOptions<mydbContext> options) : base(options) { }

        public DbSet<cusReq> cusReq{get; set;}

    }
}