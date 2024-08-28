using Microsoft.EntityFrameworkCore;
using getShipment;

namespace getShipment.Data
{
    public class mydbContext : DbContext
    {
        public mydbContext(DbContextOptions<mydbContext> options) : base(options) { }

        public DbSet<shipmentReq> shipmentInfo{get; set;}

    }
}