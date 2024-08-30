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
        public DbSet<getLogin>userInfo{get;set;}
        public DbSet<addData>addproddaa{get;set;}
        public DbSet<getOrder>orderInfo{get;set;}
        public DbSet<getShipent>shipmentInfo{get;set;}
    }

}


