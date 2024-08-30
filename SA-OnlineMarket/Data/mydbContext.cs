using getProductReq;
using Microsoft.EntityFrameworkCore;
using SA_OnlineMarket.Data;
using SA_OnlineMarket.Models;


namespace SA_OnlineMarket.Data
{
    public class mydbContext : DbContext
    {
        public mydbContext(DbContextOptions<mydbContext> options) : base(options) { }
        public DbSet<productReq> prodInfo {get;set;}
        //public DbSet<getLogin>userInfo{get;set;}
    }

}


