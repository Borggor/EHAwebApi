using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace getCart;
[Table("Cart")]
public class cartReq
{
        [Key]
        [Column("cart_ID")]
        public int cartID { get; set; }
        [Column("customer_ID")]
        public int customerID { get; set; } 
        [Column("product_ID")]
        public int productID{ get; set; }
        [Column("cart_Quantity")]
        public int cart_Quantity { get; set; }
        [Column("cart_Total")]
        public decimal cartTotal { get; set; }
}