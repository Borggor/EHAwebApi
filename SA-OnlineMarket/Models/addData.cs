using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SA_OnlineMarket.Models
{
    [Keyless]
    [Table("Products")]
    public class addProdData
{
    
    [Column("product_Name")]
    public string Name { get; set; }
    [Column("product_Des")]
    public string Description { get; set; }
    [Column("product_Stock")]
    public int Stock { get; set; }
    [Column("product_Price")]
    public decimal Price { get; set; }
}
}